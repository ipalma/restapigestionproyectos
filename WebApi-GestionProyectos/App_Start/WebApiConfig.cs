using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApi_GestionProyectos.Extensions;
using WebApi_GestionProyectos.Models;

namespace WebApi_GestionProyectos
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling =
                Newtonsoft.Json.PreserveReferencesHandling.Objects;

            config.EnableCors();
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.MessageHandlers.Add(new ManejadorMensajesAutenticacion(new GestionProyectosEntities()));

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi3",
            //    routeTemplate: "api/{controller}/{habilidades}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi2",
            //    routeTemplate: "api/{controller}/{email}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            //config.Routes.MapHttpRoute(
            //    name: "Routing por Accion",
            //    routeTemplate: "api/{controller}/{action}/{args}",
            //    defaults: new { args = RouteParameter.Optional });

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );



        }
    }
}
