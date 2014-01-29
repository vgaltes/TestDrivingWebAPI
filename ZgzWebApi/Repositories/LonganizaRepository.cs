namespace ZgzWebApi.Repositories
{
    using System.Collections.Generic;
    using ZgzWebApi.Model;

    public class LonganizaRepository
    {
        private IList<Longaniza> longanizas;
        public LonganizaRepository()
        {
            longanizas = new List<Longaniza>();
            longanizas.Add(new Longaniza { Name = "aragón", Price = 10, 
                SelledBy = new List<Shop> 
                { 
                    new Shop { Id = 1, Name = "Manolita" },
                    new Shop { Id = 2, Name = "Carnes de Aragón" }
                }
            });
            longanizas.Add(new Longaniza
            {
                Name = "setas",
                Price = 12,
                SelledBy = new List<Shop> 
                { 
                    new Shop { Id = 1, Name = "Manolita" },
                    new Shop { Id = 3, Name = "Carniceria Graus" }
                }
            });
            longanizas.Add(new Longaniza
            {
                Name = "graus",
                Price = 13,
                SelledBy = new List<Shop> 
                { 
                    new Shop { Id = 1, Name = "Manolita" },
                    new Shop { Id = 4, Name = "La Longaniza feliz" }
                }
            });
            longanizas.Add(new Longaniza
            {
                Name = "trufa",
                Price = 16,
                SelledBy = new List<Shop> 
                { 
                    new Shop { Id = 1, Name = "Manolita" },
                    new Shop { Id = 2, Name = "Carnes de Aragón" },
                    new Shop { Id = 3, Name = "Carniceria Graus" },
                    new Shop { Id = 4, Name = "La Longaniza feliz" }
                }
            });
        }

        public IList<Longaniza> GetAll()
        {
            return longanizas;
        }
    }
}
