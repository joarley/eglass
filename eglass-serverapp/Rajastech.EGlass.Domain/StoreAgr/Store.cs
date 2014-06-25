namespace Rajastech.EGlass.Domain.StoreAgr
{
    using Rajastech.EGlass.Domain.Core;
    using System;
    using System.Collections.Generic;

    public class Store : AggregateRoot<Store, Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual StoreLocalizedDetailsBase StoreLocalizedDetails { get; set; }
        public StoreType StoreType { get; set; }
        public virtual ICollection<AddressBase> Addresses { get; set; }
        public string Site { get; set; }
        public virtual ICollection<PhoneNumberBase> PhoneNumbers { get; set; }
    }
}
