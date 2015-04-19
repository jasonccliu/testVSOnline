using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testVSOnlineProject.Startup))]
namespace testVSOnlineProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
