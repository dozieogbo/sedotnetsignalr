using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NETGroupSignalR.Startup))]
namespace NETGroupSignalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
