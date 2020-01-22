using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bs609016_MIS4200_Fixed.Startup))]
namespace bs609016_MIS4200_Fixed
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
