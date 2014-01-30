namespace ZgzWebApi.Configuration
{
    using System.Web.Http;
    using System.Web;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {            
            config.MapHttpAttributeRoutes();
        }
    }
}
