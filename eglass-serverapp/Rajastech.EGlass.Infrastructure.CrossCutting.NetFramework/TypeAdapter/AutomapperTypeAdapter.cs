﻿namespace Rajastech.EGlass.Infrastructure.CrossCutting.NetFramework.TypeAdapter
{
    using AutoMapper;
    using Rajastech.EGlass.Infrastructure.CrossCutting.TypeAdapter;

    /// <summary>
    /// Automapper type adapter implementation
    /// </summary>
    public class AutomapperTypeAdapter
        : ITypeAdapter
    {
        /// <summary>
        /// <see cref="Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.Adapter.ITypeAdapter"/>
        /// </summary>
        /// <typeparam name="TSource"><see cref="Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.Adapter.ITypeAdapter"/></typeparam>
        /// <typeparam name="TTarget"><see cref="Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.Adapter.ITypeAdapter"/></typeparam>
        /// <param name="source"><see cref="Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.Adapter.ITypeAdapter"/></param>
        /// <returns><see cref="Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.Adapter.ITypeAdapter"/></returns>
        public TTarget Adapt<TSource, TTarget>(TSource source)
            where TSource : class
            where TTarget : class, new()
        {
            return Mapper.Map<TSource, TTarget>(source);
        }

        /// <summary>
        /// <see cref="Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.Adapter.ITypeAdapter"/>
        /// </summary>
        /// <typeparam name="TTarget"><see cref="Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.Adapter.ITypeAdapter"/></typeparam>
        /// <param name="source"><see cref="Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.Adapter.ITypeAdapter"/></param>
        /// <returns><see cref="Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.Adapter.ITypeAdapter"/></returns>
        public TTarget Adapt<TTarget>(object source) where TTarget : class, new()
        {
            return Mapper.Map<TTarget>(source);
        }
    }
}
