namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Mapping
{
    using Rajastech.EGlass.Domain.Core;
    using System.Data.Entity.ModelConfiguration;

    public class PhoneNumberBaseMap : EntityTypeConfiguration<PhoneNumberBase>
    {
        public PhoneNumberBaseMap()
        {
            ToTable("PhoneNumber");
        }
    }
}
