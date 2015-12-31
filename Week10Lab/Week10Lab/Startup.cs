using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week10Lab.Startup))]
namespace Week10Lab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
