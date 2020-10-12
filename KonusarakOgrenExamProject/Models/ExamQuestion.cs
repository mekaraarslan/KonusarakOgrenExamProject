using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgrenExamProject.Models
{
    public class ExamQuestion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExamQuestionId { get; set; }
        public int QuestionNumber { get; set; }

        [Required(ErrorMessage = "Soru alanı boş olamaz!")]
        public string Question { get; set; }

        [Required(ErrorMessage = "Cevap A alanı boş olamaz!")]
        public string AnswerA { get; set; }

        [Required(ErrorMessage = "Cevap B alanı boş olamaz!")]
        public string AnswerB { get; set; }

        [Required(ErrorMessage = "Cevap C alanı boş olamaz!")]
        public string AnswerC { get; set; }

        [Required(ErrorMessage = "Cevap D alanı boş olamaz!")]
        public string AnswerD { get; set; }

        [Required(ErrorMessage = "Doğru cevap alanı boş olamaz!")]
        public string CorrectAnswer { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
    }
}
