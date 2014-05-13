namespace Rajastech.EGlass.DistributedServices.WebAPI
{
    #region using
    using Ninject;
    using Ninject.Web.Common;
    using Rajastech.EGlass.Domain.Core;
    using Rajastech.EGlass.Infrastructure.CrossCutting.Logging;
    using Rajastech.EGlass.Infrastructure.CrossCutting.NetFramework.Logging;
    using Rajastech.EGlass.Infrastructure.CrossCutting.NetFramework.TypeAdapter;
    using Rajastech.EGlass.Infrastructure.CrossCutting.TypeAdapter;
    using Rajastech.EGlass.Infrastructure.Data.EntityFramework.Core.UnitOfWork;
    using System;
    using System.Configuration;
    using System.Reflection;
    using System.Web;
    using System.Web.Http;
    #endregion

    public class NinjectDependencyConfig
    {
        private static void Config(StandardKernel kernel)
        {
            //Cross Cutting IoC
            kernel.Bind<ILoggerFactory>().To<NLogLoggerFactory>();
            kernel.Bind<ITypeAdapterFactory>().To<AutomapperTypeAdapterFactory>();

            //Data IoC
            string connectionStringName = ConfigurationManager.AppSettings["connectionStringName"];
            kernel.Bind<IUnitOfWork>().To<EntityFrameworkUnitOfWork>().
                InRequestScope().WithConstructorArgument(connectionStringName);
        }

        public static void Register(HttpConfiguration config)
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            Config(kernel);

            // Install our Ninject-based IDependencyResolver into the Web API config
            config.DependencyResolver = new NinjectDependencyResolver(kernel);
        }
    }
}