using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WuLibrary001.Startup))]
namespace WuLibrary001
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
