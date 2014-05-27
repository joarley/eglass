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
    public class StoreLocalizedDetailsBaseMap : EntityTypeConfiguration<StoreLocalizedDetailsBase>
    {
        public StoreLocalizedDetailsBaseMap()
        {
            ToTable("StoreLocalizedDetails");

            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
