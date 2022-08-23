using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Food.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //what routes to ignore when recieved - tries to give pattern to check for
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // This is how it knows what name of controller / action / id are when reading in a url - default is where to start from?
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
