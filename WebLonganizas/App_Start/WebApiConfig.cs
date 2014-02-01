using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebLonganizas
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            ZgzWebApi.Configuration.WebApiConfig.Register(config);
        }
    }
}