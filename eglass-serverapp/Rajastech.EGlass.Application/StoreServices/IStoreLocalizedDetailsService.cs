namespace Rajastech.EGlass.Application.StoreServices
{
    using Rajastech.EGlass.Application.DTO.StoreDTOs;
    using Rajastech.EGlass.Domain.StoreAgr;

    public interface IStoreLocalizedDetailsService
    {
        StoreLocalizedDetailsBase CreateFrom(StoreLocalizedDetailsBaseDto storeLocalizedDetailsBaseDto);
    }
}
