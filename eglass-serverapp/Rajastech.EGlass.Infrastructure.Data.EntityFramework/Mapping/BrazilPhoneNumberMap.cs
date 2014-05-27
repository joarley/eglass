namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Mapping
{
    using Rajastech.EGlass.Domain.Core;
    using System.Data.Entity.ModelConfiguration;

    public class BrazilPhoneNumberMap : EntityTypeConfiguration<BrazilPhoneNumber>
    {
        public BrazilPhoneNumberMap()
        {
            ToTable("BrazilPhoneNumber");

            Property(x => x.DDD)
                .IsRequired()
                .HasMaxLength(3);

            Property(x => x.Numero)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}
