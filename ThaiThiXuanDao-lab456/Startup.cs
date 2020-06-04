using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThaiThiXuanDao_lab456.Startup))]
namespace ThaiThiXuanDao_lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
