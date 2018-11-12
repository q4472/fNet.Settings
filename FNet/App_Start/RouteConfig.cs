﻿using System.Web.Mvc;
using System.Web.Routing;

namespace FNet
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: null,
                url: "settings/f0/save/{*pathInfo}",
                defaults: new { controller = "F0", action = "Save" });

            routes.MapRoute(
                name: null,
                url: "settings/f0/{*pathInfo}",
                defaults: new { controller = "F0", action = "Index" });

            routes.MapRoute(
                name: null,
                url: "{*pathInfo}",
                defaults: new { controller = "Home", action = "Index" });
        }
    }
}
