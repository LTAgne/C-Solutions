using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsPart1.Exercises.Controllers
{
    public class HomeController : Controller
    {
        // GET: FizzBuzz
        public ActionResult FizzBuzz()
        {
            return View("FizzBuzz");
        }

        // GET: Fibonacci
        public ActionResult Fibonacci()
        {
            return View("Fibonacci");
        }

        // GET: Echo
        public ActionResult Echo()
        {
            return View("Echo");
        }
    }
}