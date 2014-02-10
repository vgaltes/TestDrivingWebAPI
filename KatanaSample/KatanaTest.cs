using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Owin;
using FluentAssertions;

namespace KatanaSample
{
    [TestClass]
    public class KatanaTest
    {
        [TestMethod]
        public async Task SimpleKatanaTest()
        {
            using ( var server = TestServer.Create<TestStartup>() )
            {
                HttpResponseMessage response = await server.HttpClient.GetAsync("");

                var content = await response.Content.ReadAsStringAsync();

                content.Should().Be("Hola Zaragoza!");
            }
        }

        [TestMethod]
        public async Task ErrorPageTest()
        {
            using (var server = TestServer.Create<TestStartup>())
            {
                HttpResponseMessage response = await server.HttpClient.GetAsync("fail");

                response.IsSuccessStatusCode.Should().BeFalse();
            }
        }
    }

    public class TestStartup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseErrorPage();

            app.Run(context =>
            {
                if (context.Request.Path.Value == "/fail")
                {
                    throw new Exception("Random exception");
                }
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hola Zaragoza!");
            });
        }
    }
}
