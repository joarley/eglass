namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Migrations
{
    using Rajastech.EGlass.Infrastructure.Data.EntityFramework.Core.UnitOfWork;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration :
        DbMigrationsConfiguration<EntityFrameworkUnitOfWork>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityFrameworkUnitOfWork context)
        {
            DataBaseInitializer.Seed(context);
        }
    }
}
