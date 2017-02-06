using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdsMes.WEB.Startup))]
namespace AdsMes.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
