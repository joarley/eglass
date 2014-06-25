namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Repositories
{
    using Rajastech.EGlass.Domain.Core;
    using Rajastech.EGlass.Domain.StoreAgr;
    using Rajastech.EGlass.Infrastructure.Data.EntityFramework.Core;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StoreRepository : Repository<Store, Guid>, IStoreRepository
    {
        public StoreRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            
        }
    }
}
