using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeeKeeprMVC.Startup))]
namespace BeeKeeprMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
