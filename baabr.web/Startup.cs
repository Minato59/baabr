using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(baabr.web.Startup))]
namespace baabr.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
