using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZgzWebApi.Model;

namespace ZgzWebApi.Repositories
{
    public class ShopRepository
    {
        public IList<Shop> GetAll()
        {
            return new List<Shop>
            {
                new Shop { Id = 1, Name = "Manolita" },
                new Shop { Id = 2, Name = "Carnes de Aragón" },
                new Shop { Id = 3, Name = "Carniceria Graus" },
                new Shop { Id = 4, Name = "La Longaniza feliz" }
            };
        }
    }
}
