using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YahooInfo.Startup))]
namespace YahooInfo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
