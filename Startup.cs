using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PolicyCheck.Startup))]
namespace PolicyCheck
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
