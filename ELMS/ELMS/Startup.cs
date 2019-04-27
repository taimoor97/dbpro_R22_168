using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ELMS.Startup))]
namespace ELMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
