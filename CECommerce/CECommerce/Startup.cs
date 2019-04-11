using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CECommerce.Startup))]
namespace CECommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
