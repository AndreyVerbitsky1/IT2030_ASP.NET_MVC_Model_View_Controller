using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3_by_AndreyVerbitsky.Startup))]
namespace Lab3_by_AndreyVerbitsky
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
