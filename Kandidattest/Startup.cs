using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kandidattest.Startup))]
namespace Kandidattest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
