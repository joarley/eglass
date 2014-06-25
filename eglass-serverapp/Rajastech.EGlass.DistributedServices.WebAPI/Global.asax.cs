namespace Rajastech.EGlass.DistributedServices.WebAPI
{
    using System.Web;
    using System.Web.Http;

    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configure(NinjectDependencyConfig.Register);
        }
    }
}
