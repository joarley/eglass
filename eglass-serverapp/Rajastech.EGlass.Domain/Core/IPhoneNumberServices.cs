namespace Rajastech.EGlass.Domain.Core
{
    public interface IPhoneNumberServices
    {
        string ValidNumber(PhoneNumberBase number);
        string FormatNumber(PhoneNumberBase number);
    }
}
