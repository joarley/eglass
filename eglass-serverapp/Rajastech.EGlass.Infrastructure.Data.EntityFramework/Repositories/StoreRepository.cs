

using Rajastech.EGlass.Domain.Core;

namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Repositories
{
    using Rajastech.EGlass.Domain.StoreAgr;
    using Rajastech.EGlass.Infrastructure.Data.EntityFramework.Core.Repositories;
    using System;

    public class StoreRepository : Repository<Store, Guid>, IStoreRepository
    {
        public StoreRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
