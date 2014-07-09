namespace Rajastech.EGlass.Application.StoreServices
{
    using Rajastech.EGlass.Application.Core;
    using Rajastech.EGlass.Application.CoreServices;
    using Rajastech.EGlass.Application.DTO.CoreDTOs;
    using Rajastech.EGlass.Application.DTO.StoreDTOs;
    using Rajastech.EGlass.Domain.StoreAgr;
    using Rajastech.EGlass.Infrastructure.CrossCutting;
    using Rajastech.EGlass.Infrastructure.CrossCutting.TypeAdapter;
    using Rajastech.EGlass.Infrastructure.CrossCutting.Validation;
    using System;
    using System.Linq;

    public class StoreService
    {
        private readonly ITypeAdapterFactory typeAdapterFactory;
        private readonly IValidationFactory validationFactory;
        private readonly IAddressServiceFactory addressServiceFactory;
        private readonly IStoreLocalizedDetailsServiceFactory storeLocalizedDetailsServiceFactory;
        private readonly IStoreRepository storeRepository;

        public StoreAbstractDTO AddStore(StoreAddDTO newStoreDto)
        {
            if (!Enum.IsDefined(typeof(StoreType), newStoreDto.StoreType))
                throw new ValidateException(new ValidationResult()
                    {
                        Code = "InvalidStoreType",
                        Message = "Invalid value for store type"
                    });

            Store newStore = new Store()
            {
                Name = newStoreDto.Name,
                Description = newStoreDto.Description,
                StoreType = (StoreType)newStoreDto.StoreType
            };

            //Create store details
            var storeLocalizedDetailsService = storeLocalizedDetailsServiceFactory.
                Create(newStoreDto.StoreLocalizedDetails.CountryCodeISOA2);
            var storeLocalizedDetails = storeLocalizedDetailsService.
                CreateFrom((StoreLocalizedDetailsBaseDto)newStoreDto.StoreLocalizedDetails.Content);
            newStore.StoreLocalizedDetails = storeLocalizedDetails;

            //Create store addresses
            foreach (var addressDto in newStoreDto.Addresses)
            {
                var addressService = addressServiceFactory.Create(addressDto.CountryCodeISOA2);
                var address = addressService.CreateFrom((AddressBaseDto)addressDto.Content);
                newStore.Addresses.Add(address);
            }

            var validation = validationFactory.Create<Store>();
            var validationResult = validation.Validate(newStore);
            if (validationResult.Any())
                throw new ValidateException(validationResult);

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
