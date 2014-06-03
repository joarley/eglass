namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Mapping.Store
{
    using Rajastech.EGlass.Domain.StoreAgr;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

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
