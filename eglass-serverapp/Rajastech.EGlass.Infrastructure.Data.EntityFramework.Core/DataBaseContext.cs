using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Core
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
            : base("connectionString")
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
