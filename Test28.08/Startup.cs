using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test28._08.Startup))]
namespace Test28._08
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
