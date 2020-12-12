﻿using System.Web.Http;

namespace HairForceOne.WebService
{
    /// <summary>
    /// This class contains the config for WebApi
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// This method handle the config
        /// </summary>
        /// <param name="config"></param>
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
        }
    }
}