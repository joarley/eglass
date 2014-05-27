namespace Rajastech.EGlass.Domain.Core
{

    public interface IPhoneNumberServiceFactory
    {
        IPhoneNumberServices CreateService(string countryCodeISOA2);
    }
}
