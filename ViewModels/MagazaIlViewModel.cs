using ETicaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.ViewModels
{
    public class MagazaIlViewModel
    {
        public List<Iller> IllerList { get; set; }
        public List<Magaza> magazas { get; set; }
        public int SelectedID { get; set; }
        public string username { get; set; }

    }
}
