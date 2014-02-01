using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Testing;
using ZgzWebApi.Model;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDrivingWebAPI
{
    [TestClass]
    public class WebApiODataTests
    {
        [TestMethod]
        public async Task UsingTopShouldReturnOnlyOneElement()
        {
            using ( var server = TestServer.Create<TestStartup>())
            {
                HttpResponseMessage response = await server.HttpClient.GetAsync("api/odata/shops?$top=1");

                var content = await response.Content.ReadAsAsync<IList<Shop>>();

                content.Should().HaveCount(1);
            }
        }
    }
}
