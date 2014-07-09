namespace Rajastech.EGlass.Application.CoreServices
{
    using Rajastech.EGlass.Application.DTO.CoreDTOs;
    using Rajastech.EGlass.Domain.Core;

    public interface IPhoneNumberService
    {
        PhoneNumberBase CreateFrom(PhoneNumberBaseDto phoneNumberBaseDto);
    }
}
