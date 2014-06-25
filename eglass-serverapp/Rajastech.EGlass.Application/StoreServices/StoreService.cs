namespace Rajastech.EGlass.Application.StoreServices
{
    using Rajastech.EGlass.Application.DTO.StoreDTOs;
    using Rajastech.EGlass.Domain.StoreAgr;
    using Rajastech.EGlass.Infrastructure.CrossCutting.TypeAdapter;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Rajastech.EGlass.Application.Core;

    public class StoreService
    {
        ITypeAdapterFactory typwAdapterFactory;

        public StoreAbstractDTO Add(StoreAddDTO newStoreDto)
        {
            Store newStore = new Store();

            return newStore.ProjectedAs<StoreAbstractDTO>(typwAdapterFactory.Create());
        }
    }
}
