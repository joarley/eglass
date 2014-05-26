namespace Rajastech.EGlass.Domain.Core
{
    public class AggregateRoot<TEntity, TID> : Entity<TEntity, TID>, IAggregateRoot
        where TEntity : Entity<TEntity, TID>
    {
    }
}
