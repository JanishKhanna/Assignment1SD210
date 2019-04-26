using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment1SD210.Startup))]
namespace Assignment1SD210
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
