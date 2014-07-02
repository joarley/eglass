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
    using Rajastech.EGlass.Infrastructure.CrossCutting.Validation;

    public class StoreService
    {
        ITypeAdapterFactory typeAdapterFactory;
        IValidationFactory validationFactory;
        IStoreRepository storeRepository;

        public StoreAbstractDTO AddStore(StoreAddDTO newStoreDto)
        {
            if (!Enum.IsDefined(typeof(StoreType), newStoreDto.StoreType))
                throw new Exception();

            Store newStore = new Store()
            {
                Description = newStoreDto.Description,
                Name = newStoreDto.Name,
                StoreType = (StoreType)newStoreDto.StoreType
            };

            var validation = validationFactory.Create<Store>();
            var validationResult = validation.Validate(newStore);
            if (validationResult.Any())
                throw new Exception();

            storeRepository.Add(newStore);

            return newStore.ProjectedAs<StoreAbstractDTO>(typeAdapterFactory.Create());
        }

        public void DisableStore(Guid id)
        {
            var store = storeRepository.FindById(id);
            store.Disable();
            storeRepository.Modify(store);
        }
    }
}
