using System;
// “Bring in basic C# types and runtime functionality.”

using System.Collections.Generic;
// “Support generic collections like List<T> and Dictionary<K,V>.”

using System.Linq;
// “Enable LINQ query support (not directly used here, but often included).”

using System.Web;
// “Provides core ASP.NET Web classes like HttpApplication.”

using System.Web.Mvc;
// “Enable ASP.NET MVC-specific functionality.”

using System.Web.Routing;
// “Allows us to define and register URL routing for the application.”

namespace UserManagementCrudAppDemo
// “Declare the namespace for the application – helps group related code.”
{
    public class MvcApplication : System.Web.HttpApplication
    // “Define the main application class which inherits from HttpApplication, the entry point for all ASP.NET apps.”
    {
        protected void Application_Start()
        // “This method runs once when the application first starts.”
        {
            AreaRegistration.RegisterAllAreas();
            // “Register all MVC areas (used when the app is divided into separate feature folders).”

            RouteConfig.RegisterRoutes(RouteTable.Routes);
            // “Configure the URL routing table so the app knows how to map URLs to controllers/actions.”
        }
    }
}
