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
    public class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CodeISOA2)
                .IsRequired()
                .HasMaxLength(255);

            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}