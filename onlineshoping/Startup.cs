using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(onlineshoping.Startup))]
namespace onlineshoping
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
