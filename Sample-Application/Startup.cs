using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sample_Application.Startup))]
namespace Sample_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
