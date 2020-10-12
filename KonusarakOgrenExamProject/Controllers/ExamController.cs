using System;
using System.Collections.Generic;
using System.Linq;
using KonusarakOgrenExamProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ServiceModel.Syndication;
using System.Xml;
using KonusarakOgrenExamProject.Models.ViewModels;
using KonusarakOgrenExamProject.Data;
using System.Threading.Tasks;

namespace KonusarakOgrenExamProject.Controllers
{
    [Authorize]
    public class ExamController : Controller
    {
        [HttpGet]

        public IActionResult List()
        {
            List<Exam> examList;

            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.Database.EnsureCreated();

                examList = dbContext.Exams
                    .OrderByDescending(x => x.CreatedDate)
                    .OrderBy(x => x.ExamId)
                    .ToList();
            }

            return View(examList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            try
            {
                var posts = GetTextTitles(5);

                if (posts != null)
                {
                    ExamViewModel examViewModel = new ExamViewModel();

                    List<TextViewModel> textViewModels = new List<TextViewModel>();

                    foreach (var post in posts)
                    {
                        var textViewModel = new TextViewModel()
                        {
                            Id = post.Id,
                            Title = post.Title.Text
                        };

                        textViewModels.Add(textViewModel);
                    }

                    examViewModel.TextViewModels = textViewModels;

                    return View(examViewModel);
                }
                else
                {
                    return RedirectToAction("ErrorPage", "Exam",
                        new { title = "Beklenmeyen durum!", content = "Yazılar listelemedi! Lütfen daha sonra tekrar deneyiniz." });
                }
            }
            catch (Exception ex)
            {
                //Logging
                return RedirectToAction("ErrorPage", "Exam",
                       new { title = "Beklenmeyen durum!", content = "İstenmeyen bir durum oluştu! Lütfen daha sonra tekrar deneyiniz." });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(ExamViewModel examViewModel)
        {
            if (ModelState.IsValid)
            {
                Exam exam = new Exam()
                {
                    CreatedDate = DateTime.Now,
                    Content = examViewModel.Question.Content,
                    ExamQuestions = examViewModel.Question.ExamQuestions,
                    textId = examViewModel.Question.textId,
                    Title = examViewModel.Question.Title
                };

                List<ExamQuestion> examQuestions = new List<ExamQuestion>();

                foreach (var question in examViewModel.Question.ExamQuestions)
                {
                    ExamQuestion examQuestion = new ExamQuestion()
                    {
                        AnswerA = question.AnswerA,
                        AnswerB = question.AnswerB,
                        AnswerC = question.AnswerC,
                        AnswerD = question.AnswerD,
                        Question = question.Question,
                        CorrectAnswer = question.CorrectAnswer,
                        ExamId = exam.ExamId,
                        QuestionNumber = question.QuestionNumber
                    };

                    examQuestions.Add(examQuestion);
                }

                exam.ExamQuestions = examQuestions;

                using (var dbContext = new ApplicationDbContext())
                {
                    dbContext.Database.EnsureCreated();
                    dbContext.Add(exam);
                    int insertResult = dbContext.SaveChanges();

                    if (insertResult > 0)
                    {
                        return RedirectToAction("List", "Exam");
                    }
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Lütfen boş alanları doldurunuz!";
                return View();
            }

            return RedirectToAction("Add", "Exam");
        }

        [HttpGet]
        public IActionResult ExamPage(int? id)
        {
            if (!id.HasValue)
            {
                return RedirectToAction("List");
            }

            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.Database.EnsureCreated();

                Exam exam = dbContext.Exams.Where(x => x.ExamId == id).FirstOrDefault();
                List<ExamQuestion> examQuestions = dbContext.ExamQuestions.Where(x => x.ExamId == id).ToList();
                exam.ExamQuestions = examQuestions;

                if (exam != null)
                {
                    return View(exam);
                }
                else
                {
                    return RedirectToAction("List");
                }
            }
        }

        public async Task<JsonResult> ExamAnswerControl(List<AnswerViewModel> answerModels, int examId)
        {
            if (answerModels != null)
            {
                using (var dbContext = new ApplicationDbContext())
                {
                    dbContext.Database.EnsureCreated();
                    List<ExamQuestion> examQuestions = dbContext.ExamQuestions.Where(x => x.ExamId == examId).ToList();

                    foreach (var question in examQuestions)
                    {
                        for (int i = 0; i < answerModels.Count; i++)
                        {
                            if (question.QuestionNumber == answerModels[i].Id)
                            {
                                if (question.CorrectAnswer.Equals(answerModels[i].Answer))
                                {
                                    answerModels[i].isCorrectAnswer = true;
                                }
                                else
                                {
                                    answerModels[i].isCorrectAnswer = false;
                                }
                                answerModels[i].CorrectAnswer = question.CorrectAnswer;
                            }
                        }
                    }
                    return Json(answerModels);
                }
            }
            return Json(null);
        }

        [HttpPost]
        public async Task<JsonResult> GetTextContent(string id)
        {
            var posts = GetTextTitles();

            var content = posts.Where(x => x.Id.Equals(id)).FirstOrDefault();

            return Json(content.Summary.Text);
           
        }

        public IEnumerable<SyndicationItem> GetTextTitles(int count = -1)
        {
            var url = "https://www.wired.com/feed/rss";
            var reader = XmlReader.Create(url);
            var feed = SyndicationFeed.Load(reader);
            var posts = feed.Items.OrderByDescending(x => x.PublishDate);

            if (count != -1)
            {
                var lastPosts = posts.Take(count);
                return lastPosts;
            }
            else
                return posts;
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.Database.EnsureCreated();
                Exam exam = dbContext.Exams.Where(x => x.ExamId == id).FirstOrDefault();
                if (exam != null)
                {
                    dbContext.Remove(exam);
                    dbContext.SaveChanges();
                }
            }
            return RedirectToAction("List", "Exam");
        }

        [HttpGet]
        public IActionResult ErrorPage(string title = "", string content = "")
        {
            if (String.IsNullOrEmpty(title))
            {
                title = "Bilinemyen Hata!";
            }

            if (String.IsNullOrEmpty(content))
            {
                content = "Beklenmedik bir hata oluştu. Lütfen daha sonra tekrar deneyiniz.";
            }

            ViewBag.Title = title;
            ViewBag.Content = content;

            return View();
        }
    }
}