using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ehitusmaterjalidekauplus.Startup))]
namespace Ehitusmaterjalidekauplus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
