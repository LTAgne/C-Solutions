using SSGeek.DAL;
using SSGeek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSGeek.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForumPostDAL forumDal;

        public ForumController(IForumPostDAL forumDal)
        {
            this.forumDal = forumDal;
        }


        // GET: Forum
        public ActionResult Index()
        {
            List<ForumPost> posts = forumDal.GetAllPosts();
            return View("Index", posts);
        }

        public ActionResult NewPost()
        {
            return View("NewPost", new ForumPost());
        }

        [HttpPost]
        public ActionResult NewPost(ForumPost post)
        {
            var result = forumDal.SaveNewPost(post);

            TempData["Message_Success"] = true;

            return RedirectToAction("Index");
        }

    }
}