using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShopi.WebUI.Startup))]
namespace MyShopi.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
