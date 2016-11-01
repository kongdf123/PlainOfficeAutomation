using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlainOA.Web.Startup))]
namespace PlainOA.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
