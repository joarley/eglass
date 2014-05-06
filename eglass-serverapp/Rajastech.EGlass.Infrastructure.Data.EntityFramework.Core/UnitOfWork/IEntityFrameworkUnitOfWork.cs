using System.Data.Entity;
using System.Runtime.InteropServices;
using Reply.Brazil.WCMTools.Domain.Core;

namespace Reply.Brazil.WCMTools.Infrastructure.Persistence.Data.Core.UnitOfWork
{
    public interface IEntityFrameworkUnitOfWork<TEntity> : IUnitOfWork where TEntity: class, IEntity
    {
        IDbSet<TEntity> Set();

        IDbSet<T> Set<T>() where T : class, IEntity;
    }
}