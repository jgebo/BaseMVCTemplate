using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaseMVCTemplate.Startup))]
namespace BaseMVCTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
