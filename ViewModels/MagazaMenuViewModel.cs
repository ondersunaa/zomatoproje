using ETicaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.ViewModels
{
    public class MagazaMenuViewModel: Menu
    {
        public Magaza Magaza { get; set; }
        public List<Yorum> Yorumlar { get; set; }
        public List<Menu> Menu { get; set; }
        public List<string> MagazaOzellik { get; set; }
        public string MagazaIl { get; set; }
        public double MagazaOrt { get; set; }
        public string MagazaTur { get; set; }
        public Iller Il { get; set; }
        public List<string> Ilceler { get; set; }
    }
}
