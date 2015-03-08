using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BasicWebEvents.Startup))]
namespace BasicWebEvents
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
