namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Core.Repositories
{
    using Rajastech.EGlass.Domain.Core;
    using System;

    public abstract class Repository<TEntity, TID> : IRepository<TEntity, TID>
        where TEntity : IAggregateRoot
    {
        public IUnitOfWork UnitOfWork
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public Repository(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public TEntity Add(TEntity item)
        {
            throw new NotImplementedException();
        }

        public void Remove(TID id)
        {
            throw new NotImplementedException();
        }

        public TEntity Modify(TEntity item)
        {
            throw new NotImplementedException();
        }

        public TEntity FindById(TEntity id)
        {
            throw new NotImplementedException();
        }
    }
}
