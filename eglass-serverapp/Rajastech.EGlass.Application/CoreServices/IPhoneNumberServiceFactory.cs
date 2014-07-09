namespace Rajastech.EGlass.Application.CoreServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IPhoneNumberServiceFactory
    {
        IPhoneNumberService Create(string countryCode);
    }
}
