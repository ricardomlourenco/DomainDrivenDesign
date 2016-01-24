using System.Web.Http;
using DomainDrivenDesign.Application.AutoMapper;

namespace DomainDrivenDesign.Services.SecurityAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMapperConfig.RegisterMappings();

        }
    }
}
