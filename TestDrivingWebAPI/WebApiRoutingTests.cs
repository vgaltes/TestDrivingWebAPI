using System;
using System.Net.Http;
using Microsoft.Owin.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Owin;
using System.Web.Http;
using ZgzWebApi;

namespace TestDrivingWebAPI
{
    [TestClass]
    public class WebApiRoutingTests
    {
        [TestMethod]
        public async Task GetGreetingShouldReturnGreeting()
        {
            using (var server = TestServer.Create<TestStartup>())
            {
                HttpResponseMessage response = await server.HttpClient.GetAsync("api/greeting");

                var content = await response.Content.ReadAsAsync<Greeting>();
                Assert.IsTrue(response.IsSuccessStatusCode);
                Assert.AreEqual("Hola Zaragoza!", content.Text);
            }
        }

        public class TestStartup
        {
            public void Configuration(IAppBuilder app)
            {
                var config = new HttpConfiguration();
                ZgzWebApi.Configuration.WebApiConfig.Register(config);

                app.UseWebApi(config);
            }
        }
    }
}
