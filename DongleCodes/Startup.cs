using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DongleCodes.Startup))]
namespace DongleCodes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
