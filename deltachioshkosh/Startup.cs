using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(deltachioshkosh.Startup))]
namespace deltachioshkosh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
