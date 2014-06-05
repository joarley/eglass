namespace Rajastech.EGlass.Domain.Core
{
    public interface IPhoneNumberServices
    {
        bool ValidNumber(PhoneNumberBase number);
        string FormatNumber(PhoneNumberBase number);
        string GetCountryCode(string countryISOCode);
    }
}
