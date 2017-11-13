using SSGeek.DAL;
using SSGeek.Models;
using SSGeek.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSGeek.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly IJobApplicationDAL applicationDal;
        public ApplicationController(IJobApplicationDAL jobApplicationDal)
        {
            this.applicationDal = jobApplicationDal;
        }

        // GET: Application
        // GET: Application/Index
        public ActionResult Index()
        {
            return View("Index", new ContactInfoViewModel());
        }

        // POST: Application/Index
        [HttpPost]
        public ActionResult Index(ContactInfoViewModel model)
        {
            // Sad Path
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            // Happy Path
            JobApplication currentApplication = GetInProgressJobApplication();
            currentApplication.FirstName = model.FirstName;
            currentApplication.LastName = model.LastName;
            currentApplication.PostalCode = model.PostalCode;
            currentApplication.State = model.State;
            currentApplication.Email = model.Email;

            return RedirectToAction("EmploymentStatus");
        }

        // GET: Application/EmploymentStatus
        public ActionResult EmploymentStatus()
        {
            return View("EmploymentStatus", new EmploymentStatusViewModel());
        }

        // POST: Application/EmploymentStatus
        [HttpPost]
        public ActionResult EmploymentStatus(EmploymentStatusViewModel model)
        {
            //Sad Path
            if (!ModelState.IsValid)
            {
                return View("EmploymentStatus", model);
            }


            // Happy Path
            JobApplication currentApplication = GetInProgressJobApplication();
            currentApplication.EmploymentStatus = model.EmploymentStatus;
            currentApplication.LastEmployer = model.LastEmployer;
            currentApplication.LastEmployerCity = model.LastEmployerCity;
            currentApplication.LastEmployerStartDate = model.LastEmployerStartDate;
            currentApplication.LastEmployerEndDate = model.LastEmployerEndDate;


            return RedirectToAction("ConfirmPrivacy");
        }

        // GET: Application/ConfirmPrivacy
        public ActionResult ConfirmPrivacy()
        {
            return View("ConfirmPrivacy");
        }

        // POST: Application/ConfirmPrivacy
        [HttpPost]
        public ActionResult ConfirmPrivacy(ConfirmPrivacyViewModel model)
        {
            // Sad Path
            if (!ModelState.IsValid)
            {
                return View("ConfirmPrivacy", model);
            }

            // Happy Path
            JobApplication currentApplication = GetInProgressJobApplication();
            currentApplication.DoBackgroundCheck = model.DoBackgroundCheck;
            currentApplication.SendEmails = model.SendEmails;

            applicationDal.SaveJobApplication(currentApplication);

            return RedirectToAction("Submitted");
        }

        // GET: Application/Submitted
        public ActionResult Submitted()
        {
            return View("Submitted");
        }

        private JobApplication GetInProgressJobApplication()
        {
            if(Session["Job_Application"] == null)
            {
                Session["Job_Application"] = new JobApplication();
            }

            return Session["Job_Application"] as JobApplication;
        }

    }
}