﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace doranekoWebAspCSharp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            "Employee", "Employee/{name}", new
            {
                controller = "Employee",
                action = "Index",
                name = UrlParameter.Optional
            });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            //routes.MapRoute(
            //        "Process", "Process/{action}/{id}",
            //        defaults: new
            //        {
            //            controller = "Process",
            //            action = "List",
            //            id = UrlParameter.Optional
            //        }
            //    );

            
        }
    }
}
