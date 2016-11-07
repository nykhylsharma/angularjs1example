using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(angularjs1examples.Startup))]
namespace angularjs1examples
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
