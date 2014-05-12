namespace Rajastech.EGlass.DistributedServices.WebAPI
{
    using Ninject;
    using Ninject.Web.Common;
    using System;
    using System.Web;
    using System.Web.Http;

    public class NinjectDependencyConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            // Install our Ninject-based IDependencyResolver into the Web API config
            config.DependencyResolver = new NinjectDependencyResolver(kernel);
        }
    }
}