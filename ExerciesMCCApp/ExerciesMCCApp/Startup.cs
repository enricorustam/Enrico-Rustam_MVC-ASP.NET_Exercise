using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExerciesMCCApp.Startup))]
namespace ExerciesMCCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
