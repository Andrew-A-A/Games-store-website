using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gamer.gg.Startup))]
namespace Gamer.gg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
