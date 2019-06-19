using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Tur { get; set; }
        public string Isim { get; set; }
        public string Fiyat { get; set; }
        public string Aciklama { get; set; }
        public string MagazaID { get; set; }
        
    }
}
