using System;
using System.Net.Http;
using Microsoft.Owin.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Owin;
using System.Web.Http;
using ZgzWebApi;
using System.Collections.Generic;
using ZgzWebApi.Model;

namespace TestDrivingWebAPI
{
    [TestClass]
    public class WebApiRoutingTests
    {
        [TestMethod]
        public async Task GetAllLonganizasShouldReturnAllLonganizas()
        {
            using (var server = TestServer.Create<TestStartup>())
            {
                HttpResponseMessage response = await server.HttpClient.GetAsync("api/longanizas");

                var content = await response.Content.ReadAsAsync<IList<Longaniza>>();
                Assert.IsTrue(response.IsSuccessStatusCode);
                Assert.AreEqual(4, content.Count);
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
