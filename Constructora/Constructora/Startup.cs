using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Constructora.Startup))]
namespace Constructora
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
