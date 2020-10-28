using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PollDal;

namespace Polling.Controllers
{
    [Route("question")]
    public class QuestionController : Controller
    {
        public  QuestionContext db =new QuestionContext();
        [Route ("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.Questions = db.Questions.ToList();
            return View();
        }
        [HttpPost]
        [Route("Submit")]
        public IActionResult Submit(IFormCollection iformCollection)
        {
            string[] questionIds = iformCollection["questionid"];
            foreach(var questionid in questionIds)
            {
                int answerIdCorrect = db.Questions.Find(int.Parse(questionid)).Answers.Where(a => a.IsCorrect == true).FirstOrDefault().Id;


            }
            return View("Result");
        }
    }
}
