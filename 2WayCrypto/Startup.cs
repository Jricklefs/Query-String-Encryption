using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2WayCrypto.Startup))]
namespace _2WayCrypto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
