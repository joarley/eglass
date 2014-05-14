namespace Rajastech.EGlass.Domain.Core
{
    using System;

    public class BrazilPhoneNumber : IPhoneNumber
    {
        public string DDD { get; set; }
        public string Numero { get; set; }

        public string GetFormatedNumber()
        {
            throw new NotImplementedException();
        }

        public string GetFullPhoneNumber()
        {
            throw new NotImplementedException();
        }
    }
}
