namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Mapping.Store
{
    using Rajastech.EGlass.Domain.StoreAgr;
    using System.Data.Entity.ModelConfiguration;

    public class BrazilStoreLocalizedDetailsMap : EntityTypeConfiguration<BrazilStoreLocalizedDetails>
    {
        public BrazilStoreLocalizedDetailsMap()
        {
            ToTable("BrazilStoreLocalizedDetails");

            Property(x => x.CNPJ)
                .IsUnicode(true)
                .IsRequired()
                .HasMaxLength(255);

            Property(x => x.InscricaoEstadual)
                .IsUnicode(true)
                .IsOptional()
                .HasMaxLength(255);

            Property(x => x.InscricaoMunicipal)
                .IsUnicode(true)
                .IsOptional()
                .HasMaxLength(255);

            Property(x => x.NomeFantasia)
                .IsUnicode(true)
                .IsRequired()
                .HasMaxLength(255);

            Property(x => x.RazaoSocial)
                .IsUnicode(true)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
