using SSGeek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSGeek.Controllers
{
    public class TriviaController : Controller
    {
        // GET: Trivia
        public ActionResult Index()
        {
            return View("Index", new TriviaModel());
        }

        [HttpPost]
        public ActionResult Index(TriviaModel model)
        {
            TempData.Add("Name", model.Name);
            if (model.SubmittedAnswer == "Neil Armstrong")
            {
                return RedirectToAction("Correct");
            }
            else
            {
                return RedirectToAction("Incorrect");
            }
        }

        public ActionResult Correct()
        {
            var model = new TriviaModel
            {
                Name = (string)TempData["Name"]
            };
            return View("Correct", model);
        }

        public ActionResult Incorrect()
        {
            var model = new TriviaModel
            {
                Name = (string)TempData["Name"]
            };
            return View("Incorrect", model);
        }
    }
}