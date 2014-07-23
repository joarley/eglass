namespace Rajastech.EGlass.Infrastructure.CrossCutting.NetFramework.TypeAdapter
{
    using AutoMapper;
    using Rajastech.EGlass.Infrastructure.CrossCutting.TypeAdapter;
    using System;
    using System.Linq;

    public class AutomapperTypeAdapterFactory
        : ITypeAdapterFactory
    {
        /// <summary>
        /// Used to mark when type adapter was initialized
        /// </summary>
        static bool _initialized = false;
        /// <summary>
        /// Lock of variable <seealso cref="Rajastech.EGlass.Infrastructure.CrossCutting.NetFramework.TypeAdapter.AutomapperTypeAdapterFactory._initialized"/>
        /// </summary>
        static object _initializedLock = new object();

        /// <summary>
        /// Create a new Automapper type adapter factory
        /// </summary>
        public AutomapperTypeAdapterFactory()
        {
            lock (_initializedLock)
            {
                if (_initialized) return;

                //scan all assemblies finding Automapper Profile
                var profiles = AppDomain.CurrentDomain
                                        .GetAssemblies()
                                        .SelectMany(a => a.GetTypes())
                                        .Where(t => t.BaseType == typeof(Profile) &&
                                        t.FullName != "AutoMapper.SelfProfiler`2");

                Mapper.Initialize(cfg =>
                {
                    foreach (var item in profiles)
                    {
                        cfg.AddProfile(Activator.CreateInstance(item) as Profile);
                    }
                });

                Mapper.AssertConfigurationIsValid();

                //One initialization
                _initialized = true;
            }
        }

        public ITypeAdapter Create()
        {
            return new AutomapperTypeAdapter();
        }
    }
}
