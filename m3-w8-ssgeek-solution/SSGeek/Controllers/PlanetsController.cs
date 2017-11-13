using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSGeek.Controllers
{
    public class PlanetsController : Controller
    {
        // GET: Planets
        public ActionResult Index()
        {
            return View("Index");
        }
    }
}