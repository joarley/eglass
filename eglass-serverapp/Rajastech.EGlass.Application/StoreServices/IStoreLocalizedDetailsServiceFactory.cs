using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajastech.EGlass.Application.StoreServices
{
    public interface IStoreLocalizedDetailsServiceFactory
    {
        IStoreLocalizedDetailsService Create(string countryCode);
    }
}
