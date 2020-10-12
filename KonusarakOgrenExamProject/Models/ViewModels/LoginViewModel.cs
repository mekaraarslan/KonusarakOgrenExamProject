using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgrenExamProject.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez!")]
        [Display(Name = "Kullanıcı Adı")]
        [StringLength(maximumLength: 50, 
            MinimumLength = 10, 
            ErrorMessage = "Kullanıcı adı 10 ile 50 arasında olması gerekir.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        [Display(Name = "Şifre")]
        [StringLength(maximumLength: 60, 
            MinimumLength = 10, 
            ErrorMessage = "Şifre uzunluğu 10 ile 60 karakter olması gerekir.")]
        public string Password { get; set; }
    }
}
