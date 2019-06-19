using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Models
{
    public class Kullanici
    {
        [Required]
        public string Isim { get; set; }
        [Required]
        public string Soyisim { get; set; }
        public string Resim { get; set; }
        [Required]
        public string Mail { get; set; }
        public string Tel { get; set; }
        public string Parola { get; set; }
    }
}
