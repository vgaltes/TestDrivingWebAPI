using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using Owin;

namespace KatanaSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://localhost:9000"))
            {
                Console.WriteLine("Press [enter] to quit...");
                Console.ReadLine();
            }
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseErrorPage();
    
            app.Run(context =>
            {
                if ( context.Request.Path.Value == "/fail")
                {
                    throw new Exception("Random exception");
                }
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello, world.");
            });
        }
    }
}
