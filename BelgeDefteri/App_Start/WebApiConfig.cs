using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BelgeDefteri.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //config.BindParameter(typeof(DataSourceRequest), new Kendo.Mvc.UI.WebApiDataSourceRequestModelBinder());

            // Web API routes
            config.MapHttpAttributeRoutes();
                       
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
           );
        }

    }
}