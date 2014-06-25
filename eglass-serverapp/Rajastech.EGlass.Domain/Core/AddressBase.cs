namespace Rajastech.EGlass.Domain.Core
{
    using System;
    using System.Collections.Generic;

    public abstract class AddressBase : Entity<AddressBase, Guid>
    {
        public abstract IEnumerable<string> GetAddressLines();
        public string Type { get; set; }
    }
}
