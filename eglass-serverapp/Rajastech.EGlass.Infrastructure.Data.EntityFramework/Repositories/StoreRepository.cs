namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Repositories
{
    using Rajastech.EGlass.Domain.Core;
    using Rajastech.EGlass.Domain.StoreAgr;
    using Rajastech.EGlass.Infrastructure.Data.EntityFramework.Core;
    using System;

    public class StoreRepository : Repository<Store, Guid>, IStoreRepository
    {
        public StoreRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
