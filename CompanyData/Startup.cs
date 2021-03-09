using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CompanyData.Startup))]
namespace CompanyData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
