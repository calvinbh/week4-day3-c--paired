using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(week4_day3_paired.Startup))]
namespace week4_day3_paired
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
