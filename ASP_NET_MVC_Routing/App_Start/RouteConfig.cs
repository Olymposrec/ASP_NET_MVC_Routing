using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP_NET_MVC_Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
             name: "Makaleler",
             url: "Makale/Goster/{makaleadi}",
             defaults: new { controller = "Makale", action = "Goster",makaleadi = UrlParameter.Optional }
         );
            routes.MapRoute(
              name: "About",
              url: "About",
              defaults: new { controller = "Home", action = "Index3", id = UrlParameter.Optional }
          );
            routes.MapRoute(
               name: "Contact",
               url: "Contact",
               defaults: new { controller = "Home", action = "Index2", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "Homepage",
               url: "Homepage",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default2",
                url: "{controller}/Belge/{belgeno}",
                defaults: new { controller = "Home", action = "Belge", belgeno = UrlParameter.Optional }
            );
        }
    }
}
