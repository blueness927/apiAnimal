using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace apiAnimal
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
           

            // Web API 設定和服務
            // Web API 路由
            config.EnableCors();
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "Apiv1",
                routeTemplate: "api/v1/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
