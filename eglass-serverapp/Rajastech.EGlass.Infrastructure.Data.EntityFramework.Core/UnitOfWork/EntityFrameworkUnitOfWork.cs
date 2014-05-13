namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Core.UnitOfWork
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class EntityFrameworkUnitOfWork : DbContext,
        IEntityFrameworkUnitOfWork
    {
        public EntityFrameworkUnitOfWork(string connectionString)
            : base(connectionString)
        {
        }

        public IDbSet<T> Entities<T>() where T : class
        {
            return Set<T>();
        }

        public void Save()
        {
            this.Save();
        }

        public void Discard()
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            var typesToRegister = AppDomain.CurrentDomain
                .GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => t.BaseType != null && (t.BaseType.Name == typeof(EntityTypeConfiguration<>).Name
                    || t.BaseType.Name == typeof(ComplexTypeConfiguration<>).Name));

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
