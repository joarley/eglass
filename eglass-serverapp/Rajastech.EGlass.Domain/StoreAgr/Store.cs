namespace Rajastech.EGlass.Domain.StoreAgr
{
    using Rajastech.EGlass.Domain.Core;
    using System;
    using System.Collections.Generic;

    public class Store
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public StoreType StoreType { get; set; }
        public IAddress Address { get; set; }
        public string Site { get; set; }
        public ICollection<IPhoneNumber> PhoneNumber { get; set; }
    }
}
