﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShopBeSoSinh
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            

            //routes.MapRoute(
            //    name: "chi-tiet",
            //    url: "chi-tiet/{name}_{id}",
            //    defaults: new { controller = "Product", action = "Detail", id = UrlParameter.Optional },
            //    namespaces: new[] { "ShopBeSoSinh.Controllers" }
                
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "ShopBeSoSinh.Controllers" }
            );
        }
    }
}
