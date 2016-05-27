using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JohanB_2016_05.Startup))]
namespace JohanB_2016_05
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
