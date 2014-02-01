using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin.Hosting;
using Owin;

namespace ZgzWebApiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/";

            StartOptions options = new StartOptions(baseAddress);
            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine("Server initialized. Pres ENTER to close");
                Console.ReadLine(); 
            }
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            ZgzWebApi.Configuration.WebApiConfig.Register(config);

            app.UseWebApi(config);
        }
    }
}
