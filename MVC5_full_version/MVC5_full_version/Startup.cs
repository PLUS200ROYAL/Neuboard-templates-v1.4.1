using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5_full_version.Startup))]
namespace MVC5_full_version
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
