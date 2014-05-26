namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Mapping
{
    using Rajastech.EGlass.Domain.Core;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    public class BrazilAddressMap : EntityTypeConfiguration<BrazilAddress>
    {
        public BrazilAddressMap()
        {
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

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

            Property(x => x.Rua)
                .IsRequired()
                .HasMaxLength(255);

            Property(x => x.Type)
                .IsRequired()
                .HasMaxLength(255);

        }
    }
}