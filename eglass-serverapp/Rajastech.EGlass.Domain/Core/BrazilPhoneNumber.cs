namespace Rajastech.EGlass.Domain.Core
{
    using System;

    public class BrazilPhoneNumber : Entity<BrazilPhoneNumber, Guid>, IPhoneNumber
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

        public string Type { get; set; }
    }
}
