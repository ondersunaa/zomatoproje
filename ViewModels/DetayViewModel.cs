using ETicaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.ViewModels
{
    public class DetayViewModel : Yorum
    {
        public Magaza Magaza { get; set; }
        public List<Yorumcular> YorumcuAdi { get; set; }
        public string MagazaTur { get; set; }
        public double MagazaOrtalama { get; set; }
        public Iller Il { get; set; }
        public Ilceler Ilce { get; set; }
        public List<string> Ozellikler { get; set; } 
        public List<Yorum> Yorumlar { get; set; }
        public List<Menu> Menu { get; set; }
    }
}
