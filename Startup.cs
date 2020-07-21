using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(codefirstapp.Startup))]
namespace codefirstapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
