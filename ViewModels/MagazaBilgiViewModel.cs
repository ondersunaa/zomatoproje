using ETicaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.ViewModels
{
    public class MagazaBilgiViewModel :Magaza
    {
        public string Ilismi { get; set; }
        public List<Ilceler> Ilceler { get; set; }
       public  Magaza Magaza { get; set; }
        public List<Kategori> Kategoriler { get; set; }
    }
}
