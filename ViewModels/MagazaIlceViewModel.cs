using ETicaret.Interface;
using ETicaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.ViewModels
{
    public class MagazaIlceViewModel
    {
        //private IMagaza maga;
        public List<Magaza> Magazalar { get; set; }
        public List<Ilceler> ilcelers { get; set; }
        public int SelectedID { get; set; }
        public int SelectedIDTur { get; set; }
        public bool Otopark { get; set; }
        public bool Wifi { get; set; }
        public bool AcikAlan { get; set; }
        public bool Alkol { get; set; }
        public bool MacYayini { get; set; }
        public bool Oyun { get; set; }
        public bool KKart { get; set; }
        public string Ilismi { get; set; }
        public List<Iller> IlList { get; set; }
        public List<Kategori> Kategoriler { get; set; }
        //public MagazaIlceViewModel(IMagaza _maga)
        //{
        //    maga = _maga;
        //}
       
       
    }
}
