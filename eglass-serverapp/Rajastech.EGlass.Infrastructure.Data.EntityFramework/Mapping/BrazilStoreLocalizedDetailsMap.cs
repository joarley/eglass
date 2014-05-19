using Rajastech.EGlass.Domain.StoreAgr;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Mapping
{
    public class BrazilStoreLocalizedDetailsMap : EntityTypeConfiguration<BrazilStoreLocalizedDetails>
    {
        public BrazilStoreLocalizedDetailsMap()
        {
            HasKey(x => x.Id)
              .Property(x => x.Id)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CNPJ)
                .IsRequired()
                .HasMaxLength(255);

            Property(x => x.InscricaoEstadual)
                .IsRequired()
                .HasMaxLength(255);

            Property(x => x.InscricaoMunicipal)
           .IsRequired()
           .HasMaxLength(255);

            Property(x => x.NomeFantasia)
           .IsRequired()
           .HasMaxLength(255);

            Property(x => x.RazaoSocial)
           .IsRequired()
           .HasMaxLength(255);
        }
    }
}
