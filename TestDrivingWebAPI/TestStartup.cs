

namespace TestDrivingWebAPI
{
    using System.Web.Http;
    using Owin;

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
