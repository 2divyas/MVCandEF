using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigHubProject.Startup))]
namespace GigHubProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
