namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Mapping.Core.Brazil
{
    using Rajastech.EGlass.Domain.Core.Brazil;
    using System.Data.Entity.ModelConfiguration;

    public class AddressMap : EntityTypeConfiguration<BrazilAddress>
    {
        public AddressMap()
        {
            ToTable("BrazilAddress");

            Property(x => x.Bairro)
                .IsRequired()
                .HasMaxLength(255);

            Property(x => x.CEP)
                .IsRequired()
                .HasMaxLength(9);

            Property(x => x.Cidade)
                .IsRequired()
                .HasMaxLength(255);

            Property(x => x.Complemento)
                .IsRequired()
                .HasMaxLength(255);

            Property(x => x.Numero)
                .IsRequired()
                .HasMaxLength(255);

            Property(x => x.Logradouro)
                .IsRequired()
                .HasMaxLength(255);

            Property(x => x.Type)
                .IsRequired()
                .HasMaxLength(255);

        }
    }
}