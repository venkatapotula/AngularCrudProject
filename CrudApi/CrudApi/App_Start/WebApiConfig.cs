using System.Web.Http;

namespace CrudApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //using System.Web.Http.C
            //var cors = new EnableCorsAttribute("*", "*", "*");//origins,headers,methods 
           // var cors= new EnableCorsAttribute(origins: "*", headers: "*", methods: "GET, POST, PUT, DELETE, OPTIONS");

        //config.EnableCors(cors);
        //config.EnableCors();



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
