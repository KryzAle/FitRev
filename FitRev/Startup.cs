using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FitRev.Startup))]
namespace FitRev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
