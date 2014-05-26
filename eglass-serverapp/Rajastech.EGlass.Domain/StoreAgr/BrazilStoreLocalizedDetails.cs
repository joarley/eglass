namespace Rajastech.EGlass.Domain.StoreAgr
{
    using Rajastech.EGlass.Domain.Core;
    using System;

    public class BrazilStoreLocalizedDetails : 
        StoreLocalizedDetailsBase
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
    }
}
