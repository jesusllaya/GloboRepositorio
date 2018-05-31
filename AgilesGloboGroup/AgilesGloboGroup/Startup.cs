using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AgilesGloboGroup.Startup))]
namespace AgilesGloboGroup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
