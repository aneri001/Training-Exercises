using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApiExercise
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "EmployeeApi",
                routeTemplate: "api/emp/{controller}/{role}/{id}",
                defaults: new { id = RouteParameter.Optional,role: RouteParameter.Optional }

            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


        }
    }
}
