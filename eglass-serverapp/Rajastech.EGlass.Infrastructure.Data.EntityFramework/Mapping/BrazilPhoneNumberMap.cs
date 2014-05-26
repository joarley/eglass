namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Mapping
{
    using Rajastech.EGlass.Domain.Core;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    public class BrazilPhoneNumberMap : EntityTypeConfiguration<BrazilPhoneNumber>
    {
        public BrazilPhoneNumberMap()
        {
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Numero)
                .IsRequired()
                .HasMaxLength(255);

            Property(x => x.DDD)
                .IsRequired()
                .HasMaxLength(3);

            Property(x => x.Type)
                .IsRequired()
                .HasMaxLength(255);

        }
    }
}
