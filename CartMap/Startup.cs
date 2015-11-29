using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CartMap.Startup))]
namespace CartMap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
