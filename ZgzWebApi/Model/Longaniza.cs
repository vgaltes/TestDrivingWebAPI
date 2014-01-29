namespace ZgzWebApi.Model
{
    using System.Collections;
    using System.Collections.Generic;

    public class Longaniza
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public IList<Shop> SelledBy { get; set; }
    }
}
