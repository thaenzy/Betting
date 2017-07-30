using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Betting.Startup))]
namespace Betting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
