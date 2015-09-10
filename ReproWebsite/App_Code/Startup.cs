using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReproWebsite.Startup))]
namespace ReproWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
