using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int Stok { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
