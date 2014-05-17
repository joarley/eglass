namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Core.UnitOfWork
{
    using Rajastech.EGlass.Domain.Core;
    using System.Data.Entity;

    public interface IEntityFrameworkUnitOfWork: IUnitOfWork
    {
        IDbSet<T> Entities<T>() where T : class;
    }
}