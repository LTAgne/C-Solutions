using Critter.Web.DataAccess;
using Critter.Web.Models.Data;
using Critter.Web.Models;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using Critter.Web.Crypto;

namespace Critter.Web.Controllers
{
    public class UsersController : CritterController
    {
        private readonly IUserDAL userDal;

        public UsersController(IUserDAL userDal)
            : base(userDal)
        {
            this.userDal = userDal;
        }



        // ACCOUNT MANAGEMENT ACTIONS

        [HttpGet]
        [Route("users/{username}/changepassword")]
        public ActionResult ChangePassword(string username)
        {
            var model = new ChangePasswordViewModel();
            return View("ChangePassword", model);
        }

        [HttpPost]
        [Route("users/{username}/changepassword")]
        public ActionResult ChangePassword(string username, ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("ChangePassword", model);
            }

            userDal.ChangePassword(username, model.NewPassword);

            return RedirectToAction("Dashboard", "Messages", new { username = base.CurrentUser });
        }

        [HttpGet]
        [Route("users/new")]
        public ActionResult NewUser()
        {
            if (base.IsAuthenticated)
            {
                return RedirectToAction("Dashboard", "Messages", new { username = base.CurrentUser });
            }
            else
            {
                var model = new NewUserViewModel();
                return View("NewUser", model);
            }
        }

        [HttpPost]
        [Route("users/new")]
        public ActionResult NewUser(NewUserViewModel model)
        {
            if (base.IsAuthenticated)
            {
                return RedirectToAction("Dashboard", "Messages", new { username = base.CurrentUser });
            }

            if (ModelState.IsValid)
            {
                var currentUser = userDal.GetUser(model.Username);

                if (currentUser != null)
                {
                    ViewBag.ErrorMessage = "This username is unavailable";
                    return View("NewUser", model);
                }


                HashProvider hashProvider = new HashProvider();
                string hashedPassword = hashProvider.HashPassword(model.Password); //<-- password they provided during registration
                string salt = hashProvider.SaltValue;


                var newUser = new User
                {
                    Username = model.Username,
                    Password = hashedPassword,
                    Salt = salt
                };

                // Add the user to the database
                userDal.CreateUser(newUser);

                // Log the user in and redirect to the dashboard
                base.LogUserIn(model.Username);                
                return RedirectToAction("Dashboard", "Messages", new { username = model.Username });
            }
            else
            {
                return View("NewUser", model);
            }
        }

        [HttpGet]
        [Route("login")]
        public ActionResult Login()
        {
            if (base.IsAuthenticated)
            {
                return RedirectToAction("Dashboard", "Messages", new { username = base.CurrentUser });
            }

            var model = new LoginViewModel();
            return View("Login", model);
        }

        [HttpPost]
        [Route("login")]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = userDal.GetUser(model.Username);


                if (user != null)
                {
                    HashProvider hashProvider = new HashProvider();
                    bool doesPasswordMatch = hashProvider.VerifyPasswordMatch(user.Password, model.Password, user.Salt);

                    if (!doesPasswordMatch)
                    {
                        ModelState.AddModelError("invalid-login", "The username or password combination is not valid");
                        return View("Login", model);
                    }
                }
                else                
                {
                    ModelState.AddModelError("invalid-login", "The username or password combination is not valid");
                    return View("Login", model);
                }

                // Happy Path
                base.LogUserIn(user.Username);


                //If they are supposed to be redirected then redirect them else send them to the dashboard
                var queryString = this.Request.UrlReferrer.Query;
                var urlParams = HttpUtility.ParseQueryString(queryString);
                if (urlParams["landingPage"] != null && Url.IsLocalUrl(urlParams["landingPage"]))
                {
                    // then redirect them
                    return new RedirectResult(urlParams["landingPage"]);
                }
                else if (urlParams["landingPage"] != null && !Url.IsLocalUrl(urlParams["landingPage"]))
                {
                    return RedirectToAction("LeavingSite", "Users", new { destinationUrl = urlParams["landingPage"] });
                }
                else
                {
                    return RedirectToAction("Dashboard", "Messages", new { username = user.Username });
                }

            }
            else
            {
                return View("Login", model);
            }
        }

        public ActionResult LeavingSite()
        {
            return View("LeavingSite");
        }



        [HttpGet]
        [Route("logout")]
        public ActionResult Logout()
        {
            base.LogUserOut();

            return RedirectToAction("Index", "Home");
        }


    }
}