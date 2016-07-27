using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BelgeDefteri.Startup))]
namespace BelgeDefteri
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
