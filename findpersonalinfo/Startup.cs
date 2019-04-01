using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(findpersonalinfo.Startup))]
namespace findpersonalinfo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
