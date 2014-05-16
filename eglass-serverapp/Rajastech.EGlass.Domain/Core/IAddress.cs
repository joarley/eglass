namespace Rajastech.EGlass.Domain.Core
{
    using System;
using System.Collections.Generic;

    public interface IAddress
    {
        IEnumerable<string> GetAddressLines();
    }
}
