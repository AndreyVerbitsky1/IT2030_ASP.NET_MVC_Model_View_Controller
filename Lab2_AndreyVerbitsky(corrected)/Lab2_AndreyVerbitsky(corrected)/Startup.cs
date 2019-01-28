using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab2_AndreyVerbitsky_corrected_.Startup))]
namespace Lab2_AndreyVerbitsky_corrected_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
