namespace Rajastech.EGlass.Infrastructure.CrossCutting.NetFramework.TypeAdapter.Profiles.StoreProfiles
{
    using AutoMapper;
    using Rajastech.EGlass.Application.DTO.StoreDTOs;
    using Rajastech.EGlass.Domain.StoreAgr;

    private class StoreProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Store, StoreAbstractDTO>();
        }
    }
}
