namespace TestDrivingWebAPI
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Web.Http;
    using FluentAssertions;
    using Microsoft.Owin.Testing;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Owin;
    using ZgzWebApi.Model;

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
                response.IsSuccessStatusCode.Should().BeTrue();
                content.Should().HaveCount(4);
            }
        }

        [TestMethod]
        public async Task GetLonganizaByNameShouldReturnALonganiza()
        {
            using (var server = TestServer.Create<TestStartup>())
            {
                HttpResponseMessage response = await server.HttpClient.GetAsync("api/longanizas/graus");

                var content = await response.Content.ReadAsAsync<Longaniza>();
                response.IsSuccessStatusCode.Should().BeTrue();
                content.Name.Should().Be("graus");
            }
        }

        [TestMethod]
        public async Task GetLonganizasSelledByASpecificShop()
        {
            using ( var server = TestServer.Create<TestStartup>())
            {
                HttpResponseMessage response = await server.HttpClient.GetAsync("api/shops/3/longanizas");

                var content = await response.Content.ReadAsAsync<IList<Longaniza>>();
                response.IsSuccessStatusCode.Should().BeTrue();
                content.Should().HaveCount(2);
                content[0].Name.Should().Be("setas");
                content[1].Name.Should().Be("trufa");
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
