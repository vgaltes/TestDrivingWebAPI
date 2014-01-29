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
            longanizas.Add(new Longaniza { Name = "aragón", Price = 10 });
            longanizas.Add(new Longaniza { Name = "setas", Price = 12 });
            longanizas.Add(new Longaniza { Name = "graus", Price = 13 });
            longanizas.Add(new Longaniza { Name = "trufa", Price = 16 });
        }

        public IList<Longaniza> GetAll()
        {
            return longanizas;
        }
    }
}
