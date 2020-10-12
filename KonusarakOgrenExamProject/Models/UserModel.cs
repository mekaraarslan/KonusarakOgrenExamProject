﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgrenExamProject.Models
{
    public class UserModel : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required(ErrorMessage ="Kullanıcı adı boş geçilemez!")]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required(ErrorMessage ="Şifre alanı boş geçilemez!")]
        [MaxLength(60)]
        public string Password { get; set; }
        public bool isAdmin { get; set; }
    }
}
