using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PetStoreWebClient
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Pet's food list",
                url: "petfood/list",
                defaults: new { controller = "PetFood", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Pet's food Detail",
                url: "detail/petfood/{pfID}",
                defaults: new { controller = "PetFood", action = "Detail", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Add Cart",
                url: "add-to-cart",
                defaults: new { controller = "Cart", action = "AddItem", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Cart",
                url: "cart",
                defaults: new { controller = "Cart", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
