namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Mapping
{
    using Rajastech.EGlass.Domain.Core;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    public class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CodeISOA2)
                .IsRequired()
                .HasMaxLength(10);

            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}