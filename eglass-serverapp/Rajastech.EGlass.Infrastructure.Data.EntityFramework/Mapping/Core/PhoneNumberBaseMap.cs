namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Mapping
{
    using Rajastech.EGlass.Domain.Core;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    public class PhoneNumberBaseMap : EntityTypeConfiguration<PhoneNumberBase>
    {
        public PhoneNumberBaseMap()
        {
            ToTable("PhoneNumber");

            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Type)
                .IsUnicode(true)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
