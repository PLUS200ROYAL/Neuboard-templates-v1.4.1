using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5_seed_version.Startup))]
namespace MVC5_seed_version
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
