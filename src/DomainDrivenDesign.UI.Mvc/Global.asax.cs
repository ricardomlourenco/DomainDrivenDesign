using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using DomainDrivenDesign.Application.AutoMapper;
using DomainDrivenDesign.UI.Mvc.App_Start;

namespace DomainDrivenDesign.UI.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfig.RegisterMappings();
        }
    }
}
