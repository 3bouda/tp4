using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tp4.Startup))]
namespace tp4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
