namespace Rajastech.EGlass.Domain.Core.Brazil
{
    using System;

    public class PhoneNumber : PhoneNumberBase
    {
        public string DDD { get; set; }
        public string Numero { get; set; }

        public override string GetFormatedNumber(Core.IPhoneNumberServices phoneNumberService)
        {
            return phoneNumberService.FormatNumber(this);
        }

        public override string GetFullPhoneNumber(Core.IPhoneNumberServices phoneNumberService)
        {
            string codigoPais = phoneNumberService.GetCountryCode("pt-BR");
            return codigoPais + DDD + Numero;
        }
    }
}
