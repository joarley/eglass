namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Mapping.Core
{
    using Rajastech.EGlass.Domain.Core;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    public class AddressBaseMap : EntityTypeConfiguration<AddressBase>
    {
        public AddressBaseMap()
        {
            ToTable("Address");

            HasKey(x => x.Id)
              .Property(x => x.Id)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Type).
                IsUnicode(true).IsRequired();
        }
    }
}