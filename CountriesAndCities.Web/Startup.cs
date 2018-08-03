using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CountriesAndCities.Web.Startup))]
namespace CountriesAndCities.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
