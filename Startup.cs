using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YannickTechSystems.Startup))]
namespace YannickTechSystems
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           // ConfigureAuth(app);
        }
    }
}
