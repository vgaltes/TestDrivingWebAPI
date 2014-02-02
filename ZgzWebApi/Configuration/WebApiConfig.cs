namespace ZgzWebApi.Configuration
{
    using System.Web.Http;
    using System.Web;
    using System.Linq;
    using System.Web.Http.Cors;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {            
            config.MapHttpAttributeRoutes();
            
            var cors = new EnableCorsAttribute("http://example.com", "*", "*");
            config.EnableCors(cors);

            var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes
                .FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
        }
    }
}
