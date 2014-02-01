using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using ZgzWebApi.Model;
using ZgzWebApi.Repositories;

namespace ZgzWebApi.Controllers.API.Odata
{

    [RoutePrefix("api/odata/shops")]
    public class ShopsController : ApiController
    {
        private ShopRepository shopRepository = new ShopRepository();

        [Queryable]
        [Route("")]
        public IQueryable<Shop> GetAll()
        {
            return shopRepository.GetAll().AsQueryable();
        }
    }
}
