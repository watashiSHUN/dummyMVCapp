using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dummyMVCapp.Startup))]
namespace dummyMVCapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
