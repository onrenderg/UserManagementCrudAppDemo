using System;
// “Bring in core .NET functionality, including base classes and types.”

using System.Collections.Generic;
// “Enable use of generic collections like List<T> and Dictionary<K,V>.”

using System.Linq;
// “Add support for LINQ queries – not directly used here but common in route handling.”

using System.Web;
// “Core ASP.NET classes, including HttpContext.”

using System.Web.Mvc;
// “ASP.NET MVC framework types, including Controller and routing helpers.”

using System.Web.Routing;
// “Allows defining and registering URL routing rules.”

namespace UserManagementCrudAppDemo
// “Group this routing configuration under the app’s main namespace.”
{
    public class RouteConfig
    // “Define a public class to hold route setup logic.”

    {
        public static void RegisterRoutes(RouteCollection routes)
        // “This method is called to define and register all application routes.”

        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            // “Tell ASP.NET to ignore certain routes, like .axd files used internally (e.g., trace.axd).”

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            // “Define the default route pattern:
            //    - URL segments map to controller/action/id,
            //    - If no URL is provided, use HomeController and Index() action,
            //    - The id part is optional.”
        }
    }
}
