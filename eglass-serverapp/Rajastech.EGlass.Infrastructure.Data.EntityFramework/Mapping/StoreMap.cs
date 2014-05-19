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
    public class StoreMap : EntityTypeConfiguration<Store>
    {
        public StoreMap()
        {
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
              .IsRequired()
              .HasMaxLength(255);

            Property(x => x.Description)
            .IsRequired()
            .HasMaxLength(255);

            Property(x => x.Site)
            .IsRequired()
            .HasMaxLength(255);

            Property(x => x.StoreType)
                .IsRequired();

            HasMany(x => x.Address).WithMany();

            HasMany(x => x.PhoneNumber).WithMany();
        }
    }
}
