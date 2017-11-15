using Critter.Web.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Critter.Web.Controllers
{
    public class JsonController : CritterController
    {
        private readonly IMessageDAL messageDal;
        private readonly IUserDAL userDal;

        public JsonController(IMessageDAL messageDal, IUserDAL userDal) : base(userDal)
        {
            this.messageDal = messageDal;
            this.userDal = userDal;
        }

        [Route("api/users")]
        public ActionResult GetUserList(string query)
        {
            var users = userDal.GetUsernames(query);
            var result = new { suggestions = users};
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        // GET: Json
        [Route("api/messages")]
        public ActionResult GetNewPublicMessages(DateTime sinceDate)
        {
            var newMessages = messageDal.GetPublicMessages(sinceDate);

            return Json(newMessages, JsonRequestBehavior.AllowGet);
        }

        [Route("api/search")]
        public ActionResult SearchMessages(string username, DateTime sinceDate)
        {
            var newMessages = messageDal.SearchMessagesBySender(username, sinceDate);

            return Json(newMessages, JsonRequestBehavior.AllowGet);
        }


        [Route("api/{forUser}/conversations/{withUser}")]
        public ActionResult GetNewThreadMessages(string forUser, string withUser, DateTime sinceDate)
        {
            var newConversations = messageDal.GetConversations(forUser, withUser, sinceDate);

            return Json(newConversations, JsonRequestBehavior.AllowGet);
        }


        [Route("api/{forUser}/conversations")]
        public ActionResult GetNewConversations(string forUser, DateTime sinceDate)
        {
            var newConversations = messageDal.GetConversations(forUser, sinceDate);

            return Json(newConversations, JsonRequestBehavior.AllowGet);
        }


    }
}