using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopBeSoSinh.Startup))]
namespace ShopBeSoSinh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
