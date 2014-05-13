using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using Reply.Brazil.WCMTools.Infrastructure.Persistence.Data.Core.UnitOfWork;

namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Core.UnitOfWork
{
    public class EntityFrameworkUnitOfWork<TEntity> : IEntityFrameworkUnitOfWork<TEntity> where TEntity : class, IEntity
    {
        private readonly DataBaseContext _context;

        public EntityFrameworkUnitOfWork(DataBaseContext context)
        {
            _context = context;
        }

        public IDbSet<TEntity> Set()
        {
            return _context.Set<TEntity>();
        }

        public IDbSet<T> Set<T>() where T : class, IEntity
        {
            return _context.Set<T>();
        }

        public void Commit()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                SqlException s = ex.InnerException.InnerException as SqlException;

                if (s.Number == 547)
                {
                    throw new ExceptionWithCodeErro("MSG_E0002", s.Message);
                }

                throw ex;
            }
            
        }

        //public void Rollback()
        //{
        //}
    }
}
