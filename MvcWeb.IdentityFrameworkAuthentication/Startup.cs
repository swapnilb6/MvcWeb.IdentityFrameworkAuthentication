using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcWeb.IdentityFrameworkAuthentication.Startup))]
namespace MvcWeb.IdentityFrameworkAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
