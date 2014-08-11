using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eglass.Presentation.WebbMV5.Startup))]
namespace Eglass.Presentation.WebbMV5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
