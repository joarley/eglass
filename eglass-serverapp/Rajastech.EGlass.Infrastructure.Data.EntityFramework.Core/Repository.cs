namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Core
{
    using Rajastech.EGlass.Domain.Core;
    using Rajastech.EGlass.Infrastructure.Data.EntityFramework.Core.UnitOfWork;
    using System;

    public abstract class Repository<TAggregateRoot, TID> : IRepository<TAggregateRoot, TID>
        where TAggregateRoot : class, IAggregateRoot
    {
        public IUnitOfWork UnitOfWork { get { return this.EntityFrameworkUnitOfWork; } }
        public IEntityFrameworkUnitOfWork EntityFrameworkUnitOfWork { get; private set; }

        public Repository(IUnitOfWork unitOfWork)
        {
            if (!(unitOfWork is IEntityFrameworkUnitOfWork))
                throw new ArgumentException("unitOfWork");

            this.EntityFrameworkUnitOfWork = unitOfWork as IEntityFrameworkUnitOfWork;
        }

        public TAggregateRoot Add(TAggregateRoot item)
        {
            if (item == null)
                throw new ArgumentNullException("item");

            return EntityFrameworkUnitOfWork
                .Entities<TAggregateRoot>().Add(item);
        }

        public void Remove(TID id)
        {
            var item = FindById(id);

            if (item == null) throw new InvalidOperationException();

            EntityFrameworkUnitOfWork
                .Entities<TAggregateRoot>().Remove(item);
        }

        public TAggregateRoot Modify(TAggregateRoot item)
        {
            return item;
        }

        public TAggregateRoot FindById(TID id)
        {
            return EntityFrameworkUnitOfWork
                .Entities<TAggregateRoot>().Find(id);
        }
    }
}
