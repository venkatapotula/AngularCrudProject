using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CrudApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_BeginRequest()
        {
            if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
            {
                //HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
                //HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET, POST, PUT, PATCH, DELETE, OPTIONS");
                //HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "Origin, X-Requested-With, Content-Type, Accept");
                //HttpContext.Current.Response.AddHeader("Access-Control-Max-Age", "1728000");
                //HttpContext.Current.Response.End();

                string[] allowedOrigin = new string[] { "http://localhost:4200", "http://localhost:63290" };
                var origin = HttpContext.Current.Request.Headers["Origin"];
                if (origin != null && allowedOrigin.Contains(origin))
                {
                    HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", origin);
                    //HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET,POST");
                    HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "POST");
                }



            }
        }

    }
}
