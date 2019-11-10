using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Swsu.DigitalHospital.Main.Startup))]
namespace Swsu.DigitalHospital.Main
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
