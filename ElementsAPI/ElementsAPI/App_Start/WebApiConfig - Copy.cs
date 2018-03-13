using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ElementsAPI
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			// Web API configuration and services

			// Web API routes
			config.MapHttpAttributeRoutes();

			var cors = new EnableCorsAttribute("*", "*", "*"); // see video by hemantsgovekar

			config.EnableCors(cors);

			config.Routes.MapHttpRoute(
					 name: "Common_default",
					 routeTemplate: "api/{controller}/{action}/{id}",
					 defaults: new { id = RouteParameter.Optional }
				 );

			config.Routes.MapHttpRoute(
					  name: "CommonApiAction",
					  routeTemplate: "api/{controller}/{action}",
					  defaults: new { id = RouteParameter.Optional }
				  );

			config.Routes.MapHttpRoute(
				   name: "CommonApi",
				   routeTemplate: "api/{controller}",
				   defaults: new { id = RouteParameter.Optional }
			   );


			//config.Routes.MapHttpRoute(
			//    name: "DefaultApi",
			//    routeTemplate: "api/{controller}/{id}",
			//    defaults: new { id = RouteParameter.Optional }
			//);
		}
	}
}