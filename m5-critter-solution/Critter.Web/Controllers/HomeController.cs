using Critter.Web.DataAccess;
using Critter.Web.Models;
using Critter.Web.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Critter.Web.Controllers
{
    public class HomeController : CritterController
    {
        private readonly IMessageDAL messageDal;

        public HomeController(IUserDAL userDal, IMessageDAL messageDal) : base(userDal)
        {
            this.messageDal = messageDal;
        }


        // GET: Home
        /// <summary>
        /// Home View loads a list of most recent public messages from all users
        /// </summary>        
        public ActionResult Index()
        {
            var messages = messageDal.GetPublicMessages(100);

            return View("Index", messages);
        }

        [Route("messages")]
        [ValidateInput(false)]
        public ActionResult SearchMessages(string username, string text)
        {
            var model = new SearchMessageViewModel()
            {
                Username = username,
                Text = text
            };

            if (!String.IsNullOrEmpty(username))
            {
                var messages = messageDal.SearchMessagesBySender(username, DateTime.MinValue);
                model.Messages = messages;
            }
            else if (!String.IsNullOrEmpty(text))
            {
                var messages = messageDal.SearchMessagesByText(text);
                model.Messages = messages;
            }
            
            return View("Search", model);            
        }
                        
    }
}