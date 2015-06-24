using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DiContainer.Startup))]
namespace DiContainer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
