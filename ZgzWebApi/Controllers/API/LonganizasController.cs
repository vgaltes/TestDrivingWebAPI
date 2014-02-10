namespace ZgzWebApi.Controllers.API
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Web.Http;
    using ZgzWebApi.Model;
    using ZgzWebApi.Repositories;

    [RoutePrefix("api/longanizas")]
    public class LonganizasV1Controller : ApiController
    {
        private LonganizaRepository longanizaRepository = new LonganizaRepository();

        [HttpGet]
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

        [Route("~/api/shops/{id}/longanizas")]
        public IList<Longaniza> GetByShop(int id)
        {
            return longanizaRepository.GetAll()
                .Where(l => l.SelledBy.Select(s => s.Id).ToList()
                    .Contains(id)).ToList();
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult AddLonganiza(Longaniza newLonganiza)
        {
            return Ok();
        }
    }
}
