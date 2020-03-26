using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidtaly.Startup))]
namespace Vidtaly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
