using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamCityTest2.Startup))]
namespace TeamCityTest2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
