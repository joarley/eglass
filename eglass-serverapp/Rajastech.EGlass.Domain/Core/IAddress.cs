namespace Rajastech.EGlass.Domain.Core
{
    using System;
using System.Collections.Generic;

    public interface IAddress : IEntity
    {
        IEnumerable<string> GetAddressLines();
        string Type { get; }
    }
}
