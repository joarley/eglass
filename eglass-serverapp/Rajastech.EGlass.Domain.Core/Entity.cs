namespace Rajastech.EGlass.Domain.Core
{
    using System;

    public class Entity<TEntity, TID> : IEntity, IEquatable<Entity<TEntity, TID>>
        where TEntity : Entity<TEntity, TID>
    {
        object IEntity.Id { get { return Id; } }

        public TID Id { get; set; }

        public bool Equals(Entity<TEntity, TID> other)
        {
            if (other == null)
                return false;

            if (other.IsTransient() && IsTransient())
                return ReferenceEquals(other, this);

            return other.Id.Equals(Id);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as TEntity);
        }

        public override int GetHashCode()
        {
            return IsTransient() ? base.GetHashCode() : Id.GetHashCode();
        }

        public bool IsTransient()
        {
            return Id.Equals(default(TID));
        }

        public static bool operator ==(Entity<TEntity, TID> x, Entity<TEntity, TID> y)
        {
            return Equals(x, y);
        }

        public static bool operator !=(Entity<TEntity, TID> x, Entity<TEntity, TID> y)
        {
            return !(x == y);
        }
    }
}
