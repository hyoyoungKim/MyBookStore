using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mybookstore.Startup))]
namespace Mybookstore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
