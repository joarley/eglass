namespace Rajastech.EGlass.Domain.Core
{
    using System;
    using System.Collections.Generic;

    public abstract class AddressBase : Entity<AddressBase, Guid>
    {
        public string Type { get; set; }
    }
}
