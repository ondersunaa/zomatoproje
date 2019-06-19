using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Models
{
    public class Magaza
    {
        public int MagazaId { get; set; }
        public string MagazaAdi { get; set; }
        public int IlceID { get; set; }
        public int MagazaTur { get; set; }
        public int IlID { get; set; }
        public int FavoriID { get; set; }
        public string MagazaMail { get; set; }
        public string MagazaTel { get; set; }
        public string MagazaTanitim { get; set; }
        public string FotoGenel { get; set; }
        public string FotoGenel2 { get; set; }
        public string FavoriFoto { get; set; }
        public int Kapasite { get; set; }
        public string MagazaAdres { get; set; }
        public bool AcikAlan { get; set; }
        public bool Wifi { get; set; }
        public bool Otopark { get; set; }
        public bool Alkol { get; set; }
        public bool MacYayini { get; set; }
        public bool Oyun { get; set; }
        public bool Kart { get; set; }
        public string UserID { get; set; }


    }
}
