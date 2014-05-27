namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Mapping
{
    using Rajastech.EGlass.Domain.StoreAgr;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    public class StoreMap : EntityTypeConfiguration<Store>
    {
        public StoreMap()
        {
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .IsUnicode(true)
                .IsRequired()
                .HasMaxLength(255);

            Property(x => x.Description)
                .IsUnicode(true)
                .IsOptional()
                .HasMaxLength(255);

            HasOptional(x => x.StoreLocalizedDetails)
                .WithRequired();

            Property(x => x.Site)
                .IsUnicode(true)
                .IsOptional()
                .HasMaxLength(255);

            Property(x => x.StoreType)
                .IsRequired();

            HasMany(x => x.Address)
                .WithMany()
                .Map(x => x.ToTable("Store_Address").MapRightKey("Address_Id"));

            HasMany(x => x.PhoneNumber)
                .WithMany()
                .Map(x => x.ToTable("Store_PhoneNumber").MapRightKey("PhoneNumber_Id"));
        }
    }
}
