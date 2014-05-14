namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Core.UnitOfWork
{
    using Rajastech.EGlass.Domain.Core;

    public static class EntityFrameworkUnitOfWorkFactory
    {
        public static IUnitOfWork Create(string connectionString)
        {
            return new EntityFrameworkUnitOfWork(connectionString);
        }
    }
}
