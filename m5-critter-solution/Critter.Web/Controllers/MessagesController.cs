using Critter.Web.DataAccess;
using Critter.Web.Models.Data;
using Critter.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Critter.Web.Filters;
using System.Net;

namespace Critter.Web.Controllers
{    
    public class MessagesController : CritterController
    {
        private readonly IMessageDAL messageDal;

        public MessagesController(IMessageDAL messageDal, IUserDAL userDal) :
            base(userDal)
        {
            this.messageDal = messageDal;
        }


        [Route("users/{username}/dashboard")]
        [CritterAuthorizationFilter]
        public ActionResult Dashboard(string username)
        {
            var conversations = messageDal.GetConversations(username);
            return View("Dashboard", conversations);
        }

        [Route("users/{forUser}/conversations/{withUser}")]
        [CritterAuthorizationFilter]
        public ActionResult GetConversationThread(string forUser, string withUser)
        {
            var conversationThread = messageDal.GetConversations(forUser, withUser);
            return View("Conversation", conversationThread);
        }



        [Route("users/{username}/messages")]
        [CritterAuthorizationFilter]
        public ActionResult SentMessages(string username)
        {
            var messages = messageDal.GetAllSentMessageForUser(username);
            return View("SentMessages", messages);
        }

        [HttpGet]
        [Route("users/{username}/messages/new")]
        public ActionResult NewMessage()
        {
            var model = new NewMessageViewModel();
            return View("NewMessage", model);
        }

        [HttpPost]
        [Route("users/{username}/messages/new")]
        [ValidateAntiForgeryToken]
        public ActionResult NewMessage(string username, NewMessageViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("NewMessage", model);
            }

            var message = new Message
            {
                IsPrivate = model.IsPrivate,
                MessageText = model.MessageText,
                Sender = base.CurrentUser,
                Recipient = model.Recipient,
            };

            messageDal.CreateMessage(message);

            return RedirectToAction("Dashboard", "Messages", new { username = base.CurrentUser });
        }

        [HttpGet]
        [Route("users/{username}/messages/{messageId}/delete")]
        [CritterAuthorizationFilter]
        public ActionResult DeleteMessage(int messageId, string username)
        {
            var message = messageDal.GetMessage(messageId);

            if (message == null)
            {
                // message does not exist by that id
                return new HttpNotFoundResult();
            }

            if(message.Sender.ToLower() != username.ToLower())
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }

            return View("DeleteMessage", message);
        }

        [HttpPost]
        [Route("users/{username}/messages/{messageId}/delete")]
        [CritterAuthorizationFilter]
        public ActionResult DeleteMessage(string username, Message model)
        {
            var message = messageDal.GetMessage(model.MessageId);

            if (message == null)
            {
                return new HttpNotFoundResult();
            }
            if(message.Sender.ToLower() != username.ToLower())
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }

            messageDal.DeleteMessage(model.MessageId);
            return RedirectToAction("SentMessages");
        }
    }
}