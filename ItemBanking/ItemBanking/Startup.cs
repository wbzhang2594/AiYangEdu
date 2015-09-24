using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ItemBanking.Startup))]
namespace ItemBanking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
