﻿namespace Rajastech.EGlass.Domain.Core.Brazil
{
    using System;
    using System.Collections.Generic;

    public class Address : AddressBase
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }

        public string GetFormatedCEP(ICEPServices cepService)
        {
            return cepService.FormatCEP(this.CEP);
        }

        public override IEnumerable<string> GetAddressLines()
        {
            yield return string.Format("{0}, {1} {2}",
                this.Logradouro, this.Numero, this.Complemento); //Line 1
            yield return this.Bairro; //Line 2
            yield return this.Cidade + " - " + this.Estado; //Line 3
            yield return this.CEP; //line 4
        }
    }
}
