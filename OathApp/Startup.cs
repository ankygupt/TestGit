using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OathApp.Startup))]
namespace OathApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
