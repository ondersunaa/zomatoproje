
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Models
{
    public class Yorum
    {
        public int YorumID { get; set; }
        public int MagazaId { get; set; }
        [Required(ErrorMessage = "Lütfen Puan Giriniz")]
        public double Puan { get; set; }
        [Required(ErrorMessage = "Lütfen Başlık Giriniz")]
        public string Baslik { get; set; }
        public string user { get; set; }
        [Required(ErrorMessage = "Lütfen Mesajınızı Giriniz")]
        public string YorumIcerik { get; set; }

    }
}
