using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GardenWeb.Startup))]
namespace GardenWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
