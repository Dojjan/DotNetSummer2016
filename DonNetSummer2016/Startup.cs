using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DonNetSummer2016.Startup))]
namespace DonNetSummer2016
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
