namespace Rajastech.EGlass.Domain.Core
{

    public interface IRepository<TAggregateRoot, TID>
        where TAggregateRoot : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }

        TAggregateRoot Add(TAggregateRoot item);
        void Remove(TID id);
        TAggregateRoot Modify(TAggregateRoot item);
        TAggregateRoot FindById(TID id);
    }
}
