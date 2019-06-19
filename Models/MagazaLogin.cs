using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Models
{
    public class MagazaLogin
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz.")]
        [Display(Name = "Kullanıcı Adınız")]
        public string MagazaIsim { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        [Display(Name = "Parolanız")]
        [DataType(DataType.Password)]
        public string Parola { get; set; }
    }
}
