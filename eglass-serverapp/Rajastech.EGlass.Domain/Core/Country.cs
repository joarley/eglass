namespace Rajastech.EGlass.Domain.Core
{
    using System;

    public class Country : Entity<Country, Guid>
    {
        public string CodeISOA2 { get; set; }
        public string Name { get; set; }
    }
}
