namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Mapping.Core.Brazil
{
    using Rajastech.EGlass.Domain.Core;
    using System.Data.Entity.ModelConfiguration;
    using Rajastech.EGlass.Domain.Core.Brazil;

    public class PhoneNumberMap : EntityTypeConfiguration<BrazilPhoneNumber>
    {
        public PhoneNumberMap()
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
