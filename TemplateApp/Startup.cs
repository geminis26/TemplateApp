using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TemplateApp.Startup))]
namespace TemplateApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
