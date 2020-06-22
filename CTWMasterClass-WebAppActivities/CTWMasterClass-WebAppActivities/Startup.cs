using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CTWMasterClass_WebAppActivities.Startup))]
namespace CTWMasterClass_WebAppActivities
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
