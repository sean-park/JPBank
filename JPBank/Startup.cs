using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JPBank.Startup))]
namespace JPBank
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
