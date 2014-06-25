namespace Rajastech.EGlass.Domain.Core
{
    using System;
    using System.Linq;

    public abstract class ValueObject<TValueObject> : IValueObject, IEquatable<TValueObject>
         where TValueObject : ValueObject<TValueObject>
    {
        public bool Equals(TValueObject other)
        {
            if (other == null)
                return false;

            var publicProperties = GetType().GetProperties();

            if (publicProperties != null && publicProperties.Any())
                return publicProperties
                    .All(item => item.GetValue(this, null)
                    .Equals(item.GetValue(other, null)));

            return true;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, this))
                return true;

            if (obj == null)
                return false;

            var item = obj as ValueObject<TValueObject>;

            if (item == null)
                return false;

            return Equals((TValueObject)item);
        }



        public override int GetHashCode()
        {
            var hashCode = 31;
            var changeMultiplier = false;
            const int index = 1;

            var publicProperties = GetType().GetProperties();

            if (publicProperties != null && publicProperties.Any())
            {
                foreach (var value in publicProperties
                    .Select(item => item.GetValue(this, null)))
                {
                    if (value != null)
                    {
                        hashCode = hashCode * ((changeMultiplier) ? 59 : 114)
                            + value.GetHashCode();
                        changeMultiplier = !changeMultiplier;
                    }
                    else
                        hashCode = hashCode ^ (index * 13);
                }
            }

            return hashCode;
        }

        public static bool operator ==(ValueObject<TValueObject> x, ValueObject<TValueObject> y)
        {
            return Equals(x, y);
        }

        public static bool operator !=(ValueObject<TValueObject> x, ValueObject<TValueObject> y)
        {
            return !(x == y);
        }
    }
}
