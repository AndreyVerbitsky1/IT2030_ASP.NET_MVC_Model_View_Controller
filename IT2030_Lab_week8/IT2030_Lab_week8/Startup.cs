using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IT2030_Lab_week8.Startup))]
namespace IT2030_Lab_week8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
