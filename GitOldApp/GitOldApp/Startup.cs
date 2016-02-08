using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitOldApp.Startup))]
namespace GitOldApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
