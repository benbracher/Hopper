using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hopper.WebMVC.Startup))]
namespace Hopper.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
