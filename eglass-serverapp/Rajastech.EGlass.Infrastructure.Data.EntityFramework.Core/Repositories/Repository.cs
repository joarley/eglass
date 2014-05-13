using Reply.Brazil.WCMTools.Infrastructure.Persistence.Data.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Core.Repositories
{
    public abstract class Repository<TEntity, TID> : IRepository<TEntity, TID> where TEntity : class, IEntity
    {
        private readonly IEntityFrameworkUnitOfWork<TEntity> _context;

        public IUnitOfWork UnitOfWork
        {
            get { return _context; }
        }

        protected IDbSet<TEntity> Entities
        {
            get { return _context.Set(); }
        }

        protected IDbSet<T> Set<T>() where T : class, IEntity
        {
            return _context.Set<T>();
        }

        protected Repository(IEntityFrameworkUnitOfWork<TEntity> context)
        {
            this._context = context;
        }

        public TEntity Add(TEntity item)
        {
            return item == null ? null : Entities.Add(item);
        }

        public void Remove(TID id)
        {
            var ent = FindById(id);

            if (ent == null) throw new InvalidOperationException();

            Entities.Remove(ent);
        }

        public TEntity Modify(TEntity item)
        {
            return item;
        }

        public TEntity FindById(TID id)
        {
            return Entities.Find(id);
        }

        public IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> query, string filterField, object filterValue)
        {
           IQueryable<TEntity> result = Entities.Where(query);

            if (!string.IsNullOrEmpty(filterField))
            {
                var filters = new FilterParam()
                {
                    Filters = new List<FilterParam>()
                    {
                        new FilterParam()
                        {
                            Field = filterField,
                            Operator = "eq",
                            Value = filterValue.ToString()
                        }
                    }
                };

                var parse = new FilterParse<TEntity>();
                var qry = parse.Parse(filters, result);
                if (qry != null)
                    result = result.Provider.CreateQuery<TEntity>(qry);
            }

            return result;
        }

        public IEnumerable<TEntity> GetAll(string filterField, object filterValue)
        {
            IQueryable<TEntity> result = Entities;

            if (!string.IsNullOrEmpty(filterField))
            {
                var filters = new FilterParam()
                {
                    Filters = new List<FilterParam>()
                    {
                        new FilterParam()
                        {
                            Field = filterField,
                            Operator = "eq",
                            Value = filterValue.ToString()
                        }
                    }
                };

                var parse = new FilterParse<TEntity>();
                var qry = parse.Parse(filters, result);
                if (qry != null)
                    result = result.Provider.CreateQuery<TEntity>(qry);
            }

            return result;
        }

        public PagedResult<TEntity> GetPaged(PagedParam param, string filterField, object filterValue)
        {
            IQueryable<TEntity> entities = Entities;

            if (!string.IsNullOrEmpty(filterField))
            {
                var filters = new List<FilterParam>()
                {
                    new FilterParam()
                    {
                        Field = filterField,
                        Operator = "eq",
                        Value = filterValue.ToString()
                    }
                };

                if (param.Filter != null && param.Filter.Filters.Any())
                    filters.AddRange(param.Filter.Filters);

                param.Filter = new FilterParam()
                {
                    Logic = "and",
                    Filters = filters
                };
            }

            return FilterEntity(entities, param);
        }

        protected PagedResult<TEnt> FilterEntity<TEnt>(IQueryable<TEnt> entities, PagedParam param)
        {
            if (param.Filter != null)
            {
                var parse = new FilterParse<TEnt>();
                var qry = parse.Parse(param.Filter, entities);
                if (qry != null)
                    entities = entities.Provider.CreateQuery<TEnt>(qry);
            }
            if (param.Sort == null || !param.Sort.Any())
            {
                string propert = null;

                propert = typeof (TEnt).GetProperty("Id") != null ? "Id" : typeof (TEnt).GetProperties()[0].Name;
                param.Sort = new List<SortParam>()
                {
                    new SortParam() {Field = propert, Dir = "asc"}
                };
            }

            var order = new OrderbyParse<TEnt>();
            entities = entities.Provider.CreateQuery<TEnt>(order.Parse(param.Sort, entities));

            return new PagedResult<TEnt>()
            {
                Total = entities.Count(),
                Result = param.Take == 0 ? entities : entities.Skip(param.Skip).Take(param.Take)
            };
        }
    }
}