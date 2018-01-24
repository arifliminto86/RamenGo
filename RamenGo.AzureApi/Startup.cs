using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(RamenGo.AzureApi.Startup))]

namespace RamenGo.AzureApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}