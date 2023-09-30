using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Assignment_1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
               name: "AddTenApi",
               routeTemplate: "api/AddTen/{id}",
               defaults: new { controller = "AddTen", action = "Get", id = RouteParameter.Optional }
           );
        }
    }
}
