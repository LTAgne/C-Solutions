using SSGeek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSGeek.Controllers
{
    public class CalculatorsController : Controller
    {
        // INSTRUCTIONS
        // As a part of each exercise you will need to 
        // - develop a view for AlienAge, AlienWeight, and AlienTravel that displays a form to submit data
        // - create a new action to process the form submission (e.g. AlienAgeResult, AlienWeightResult, etc.)
        // - create a view that displays the submitted form result

        // GET: Calculators/AlienAge
        public ActionResult AlienAge()
        {
            ViewBag.PlanetList = planets;

            return View("AlienAge", new AlienAgeModel());
        }

        public ActionResult AlienAgeResult(AlienAgeModel model)
        {            
            return View("AlienAgeResult", model);
        }

        // GET: Calculators/AlienWeight
        public ActionResult AlienWeight()
        {
            ViewBag.PlanetList = planets;

            return View("AlienWeight", new AlienWeightModel());
        }

        public ActionResult AlienWeightResult(AlienWeightModel model)
        {            
            return View("AlienWeightResult", model);
        }

        // GET: Calculators/AlienTravel
        public ActionResult AlienTravel()
        {
            ViewBag.PlanetList = planets;
            ViewBag.TransportationModes = transportationModes;

            return View("AlienTravel", new AlienTravelModel());
        }

        public ActionResult AlienTravelResult(AlienTravelModel model)
        {            
            return View("AlienTravelResult", model);
        }

        private List<SelectListItem> planets = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Mercury" },
            new SelectListItem() { Text = "Venus" },
            new SelectListItem() { Text = "Mars" },
            new SelectListItem() { Text = "Jupiter" },
            new SelectListItem() { Text = "Saturn" },
            new SelectListItem() { Text = "Neptune" },
            new SelectListItem() { Text = "Uranus" }
        };

        private List<SelectListItem> transportationModes = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Walking", Value="walking" },
            new SelectListItem() { Text = "Car", Value = "car" },
            new SelectListItem() { Text = "Bullet Train", Value = "bullet train" },
            new SelectListItem() { Text = "Boeing 747", Value = "boeing 747" },
            new SelectListItem() { Text = "Concorde", Value = "concorde" }
        };
    }
}