using Rajastech.EGlass.Domain.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Mapping
{
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
