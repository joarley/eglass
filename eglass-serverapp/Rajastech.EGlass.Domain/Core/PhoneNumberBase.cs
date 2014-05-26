namespace Rajastech.EGlass.Domain.Core
{
    using System;

    public abstract class PhoneNumberBase : Entity<PhoneNumberBase, Guid>
    {
        public abstract string GetFormatedNumber();
        public abstract string GetFullPhoneNumber();
        public string Type { get; set; }
    }
}
