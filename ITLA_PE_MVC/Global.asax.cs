using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.IO.Compression;

namespace ITLA_PE_MVC
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalFilters.Filters.Add(new ContentSecurityPolicyFilterAttribute());
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            

            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }


    public class CompressAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            var _encodingsAccepted = filterContext.HttpContext.Request.Headers["Accept-Encoding"];
            if (string.IsNullOrEmpty(_encodingsAccepted)) return;

            _encodingsAccepted = _encodingsAccepted.ToLowerInvariant();
            var _response = filterContext.HttpContext.Response;

            if (_encodingsAccepted.Contains("deflate"))
            {
                _response.AppendHeader("Content-encoding", "deflate");
                _response.Filter = new DeflateStream(_response.Filter, CompressionMode.Compress);
            }
            else if (_encodingsAccepted.Contains("gzip"))
            {
                _response.AppendHeader("Content-encoding", "gzip");
                _response.Filter = new GZipStream(_response.Filter, CompressionMode.Compress);
            }

            _response.AddHeader("Content-Security-Policy", "default-src *; style-src * 'unsafe-inline';  script-src * 'unsafe-inline' 'unsafe-eval'; img-src * data: 'unsafe-inline'; connect-src * 'unsafe-inline'; frame-src *;");



        }
    }

    public class ContentSecurityPolicyFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var response = filterContext.HttpContext.Response;
            response.AddHeader("Content-Security-Policy", "default-src *; style-src * 'unsafe-inline';  script-src * 'unsafe-inline' 'unsafe-eval'; img-src * data: 'unsafe-inline'; connect-src * 'unsafe-inline'; frame-src *;");
            base.OnActionExecuting(filterContext);
        }
    }

}


