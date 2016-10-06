using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PicLib.Startup))]
namespace PicLib
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
