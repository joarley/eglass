namespace Rajastech.EGlass.Domain.Core
{
    using System;

    public class BrazilPhoneNumber : PhoneNumberBase
    {
        public string DDD { get; set; }
        public string Numero { get; set; }

        public override string GetFormatedNumber()
        {
            throw new NotImplementedException();
        }

        public override string GetFullPhoneNumber()
        {
            throw new NotImplementedException();
        }
    }
}
