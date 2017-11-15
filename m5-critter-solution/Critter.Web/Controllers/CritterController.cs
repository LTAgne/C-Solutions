using Critter.Web.DataAccess;
using Critter.Web.Models.Data;
using Critter.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Critter.Web.Controllers
{
    public class CritterController : Controller
    {
        private const string UsernameKey = "Critter_UserName";
        private readonly IUserDAL userDal;

        public CritterController(IUserDAL userDal)
        {
            this.userDal = userDal;
        }


        /// <summary>
        /// Gets the value from the Session
        /// </summary>
        public string CurrentUser
        {
            get
            {
                string username = string.Empty;

                //Check to see if user cookie exists, if not create it
                if (Session[UsernameKey] != null)
                {
                    username = (string)Session[UsernameKey];
                }

                return username;
            }
        }

        /// <summary>
        /// Returns bool if user has authenticated in
        /// </summary>        
        public bool IsAuthenticated
        {
            get
            {
                return Session[UsernameKey] != null;
            }
        }

        /// <summary>
        /// "Logs" the current user in
        /// </summary>
        public void LogUserIn(string username)
        {
            //Session.Abandon();
            //Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            Session[UsernameKey] = username;            
        }

        /// <summary>
        /// "Logs out" a user by removing the cookie.
        /// </summary>
        public void LogUserOut()
        {
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
        }


        [ChildActionOnly]
        public ActionResult GetAuthenticatedUser()
        {
            User model = null;

            if (IsAuthenticated)
            {
                model = userDal.GetUser(CurrentUser);
            }

            return PartialView("_AuthenticationBar", model);
        }


    }
}