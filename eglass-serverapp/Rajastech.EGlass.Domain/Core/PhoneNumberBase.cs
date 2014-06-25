namespace Rajastech.EGlass.Domain.Core
{
    using System;

    public abstract class PhoneNumberBase : Entity<PhoneNumberBase, Guid>
    {
        public abstract string GetFormatedNumber(IPhoneNumberServices phoneService);
        public abstract string GetFullPhoneNumber(IPhoneNumberServices phoneService);
        public string Type { get; set; }
    }
}
