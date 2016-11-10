using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Clarity.Startup))]
namespace Clarity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
