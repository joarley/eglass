namespace Rajastech.EGlass.Domain.Core
{
    public class Entity<TID> : IEntity
    {
        object IEntity.Id { get { return Id; } }

        public TID Id { get; set; }
    }
}
