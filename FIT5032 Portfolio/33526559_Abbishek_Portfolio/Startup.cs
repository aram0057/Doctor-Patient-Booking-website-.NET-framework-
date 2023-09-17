using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_33526559_Abbishek_Portfolio.Startup))]
namespace _33526559_Abbishek_Portfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
