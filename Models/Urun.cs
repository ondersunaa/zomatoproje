using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Models
{
    public class Urun
    {
        public int UrunID { get; set; }
        public string UrunIsmı { get; set; }
        public float UrunFiyati { get; set; }
        public int MagazaId { get; set; }
        public string UrunResim { get; set; }
        public int TurID { get; set; }


    }
}
