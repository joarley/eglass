namespace Rajastech.EGlass.Domain.Core
{
    using System;
    using System.Collections.Generic;

    public class BrazilAddress : Entity<BrazilAddress, Guid>, IAddress
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Type { get; set; }


        public IEnumerable<string> GetAddressLines()
        {
            throw new NotImplementedException();
        }
    }
}
