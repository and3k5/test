using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace test
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            
            RouteTable.Routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            RouteTable.Routes.MapRoute("Default", "", new { controller = "Test", action = "Test" });
        }
    }
}
