using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgrenExamProject.Models.ViewModels
{
    public class AnswerViewModel
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public string CorrectAnswer { get; set; }
        public bool? isCorrectAnswer { get; set; }
    }
}
