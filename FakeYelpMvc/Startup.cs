using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FakeYelpMvc.Startup))]
namespace FakeYelpMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
