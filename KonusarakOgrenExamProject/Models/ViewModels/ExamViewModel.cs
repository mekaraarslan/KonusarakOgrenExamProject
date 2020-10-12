using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgrenExamProject.Models.ViewModels
{
    public class ExamViewModel
    {
        public List<TextViewModel> TextViewModels { get; set; }
        public Exam Question { get; set; }
    }
}
