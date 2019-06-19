using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Models
{
    public class MagazaKullanici
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "İşletme Adı")]
        public string MagazaAdi { get; set; }
        [Required]
        [Display(Name = "Kullanıcı Adı")]
        public string KullaciAdi { get; set; }   
        [Required]
        [Display(Name = "İl")]
        public int IlID { get; set; }
        [Required]
        [Display(Name = "Tür")]
        public int MagazaTur { get; set; }
        [Required]
        [Display(Name = "Mail")]
        public string MagazaMail { get; set; }
        [Required]
        [Display(Name = "Telefon")]
        public string MagazaTel { get; set; }
        [Required]
        [Display(Name = "Hakkınızda")]
        public string MagazaTanitim { get; set; }
        [Required]
        [Display(Name = "Genel Fotoğraf")]
        public string FotoGenel { get; set; }
        [Required]
        [Display(Name = "Genel Fotoğraf 2")]
        public string FotoGenel2 { get; set; }
        [Required]
        [Display(Name = "Kapasite")]
        public int Kapasite { get; set; }
        [Required]
        [Display(Name = "Adres")]
        public string MagazaAdres { get; set; }
        [Display(Name = "Açık Alan")]
        public bool AcikAlan { get; set; }
        [Display(Name = "Wi-Fi")]
        public bool Wifi { get; set; }
        [Display(Name = "Otopark")]
        public bool Otopark { get; set; }
        [Display(Name = "Alkol")]
        public bool Alkol { get; set; }
        [Display(Name = "Maç Yayını")]
        public bool MacYayini { get; set; }
        [Display(Name = "Oyun")]
        public bool Oyun { get; set; }
        [Display(Name = "Kredi Kartı")]
        public bool Kart { get; set; }
        [Required]
        [Display(Name = "Şifre")]
        public string Parola { get; set; }
        
        
    }
}
