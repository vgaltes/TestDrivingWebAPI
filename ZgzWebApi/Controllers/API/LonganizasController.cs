namespace ZgzWebApi.Controllers.API
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;
    using ZgzWebApi.Model;
    using ZgzWebApi.Repositories;

    [RoutePrefix("api/longanizas")]
    public class LonganizasController : ApiController
    {
        private LonganizaRepository longanizaRepository = new LonganizaRepository();

        [Route("")]
        public IList<Longaniza> GetAll()
        {
            return longanizaRepository.GetAll();
        }

        [Route("{name}")]
        public Longaniza GetLonganiza(string name)
        {
            return longanizaRepository.GetAll().Where(l => l.Name == name).First();
        }
    }
}
