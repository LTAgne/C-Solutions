using FormsWithHttpPost.DAL;
using FormsWithHttpPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormsWithHttpPost.Controllers
{
    public class HomeController : Controller
    {
        private readonly IReviewDAL reviewDal;

        public HomeController(IReviewDAL reviewDal)
        {
            this.reviewDal = reviewDal;
        }

        // GET: Home
        public ActionResult Index()
        {
            List<Review> reviews = reviewDal.GetAllReviews();
            return View("Index", reviews);
        }

        public ActionResult NewReview()
        {
            return View("NewReview", new Review());
        }

        [HttpPost]
        public ActionResult NewReview(Review model)
        {
            reviewDal.SaveReview(model);
            return RedirectToAction("Index");
        }
    }
}