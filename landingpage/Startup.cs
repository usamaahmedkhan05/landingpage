using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(landingpage.Startup))]
namespace landingpage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
