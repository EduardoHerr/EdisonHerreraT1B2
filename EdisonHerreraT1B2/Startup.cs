using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EdisonHerreraT1B2.Startup))]
namespace EdisonHerreraT1B2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
