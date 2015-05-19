using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(karthikrepo.Startup))]
namespace karthikrepo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
