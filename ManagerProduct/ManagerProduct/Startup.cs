using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ManagerProduct.Startup))]
namespace ManagerProduct
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
