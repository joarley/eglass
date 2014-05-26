namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Mapping
{
    using Rajastech.EGlass.Domain.Core;
    using System.Data.Entity.ModelConfiguration;

    public class AddressBaseMap : EntityTypeConfiguration<AddressBase>
    {
        public AddressBaseMap()
        {
            ToTable("Address");
        }
    }
}