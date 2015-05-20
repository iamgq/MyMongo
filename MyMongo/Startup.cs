using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMongo.Startup))]
namespace MyMongo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
