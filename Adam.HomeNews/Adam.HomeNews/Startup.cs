using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Adam.HomeNews.Startup))]
namespace Adam.HomeNews
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
