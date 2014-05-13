namespace Rajastech.EGlass.Application.Core
{
    using Rajastech.EGlass.Domain.Core;
    using Rajastech.EGlass.Infrastructure.CrossCutting.TypeAdapter;
    using System.Collections.Generic;
    using System.Linq;

    public static class ProjectionExtensions
    {
        public static TProjection ProjectedAs<TProjection>(this IEntity item, ITypeAdapter adapter)
            where TProjection : class, new()
        {
            return adapter.Adapt<IEntity, TProjection>(item);
        }

        public static TProjection ProjectedAs<TProjection>(this IEnumerable<IEntity> list, ITypeAdapter adapter)
        where TProjection : class, new()
        {
            return adapter.Adapt<IEnumerable<IEntity>, TProjection>(list.ToArray());
        }

        public static TProjection ProjectedAs<TProjection>(this IValueObject item, ITypeAdapter adapter)
            where TProjection : class, new()
        {
            return adapter.Adapt<IValueObject, TProjection>(item);
        }

        public static TProjection ProjectedAs<TProjection>(this IEnumerable<IValueObject> list, ITypeAdapter adapter)
            where TProjection : class, new()
        {
            return adapter.Adapt<IEnumerable<IValueObject>, TProjection>(list.ToArray());
        }
    }
}
