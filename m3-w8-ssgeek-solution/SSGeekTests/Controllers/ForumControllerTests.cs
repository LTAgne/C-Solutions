using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSGeek.Controllers;
using SSGeek.Models;
using SSGeekTests.TestDouble;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SSGeek.Controllers.Tests
{
    [TestClass()]
    public class ForumControllerTests
    {
        /*
         * One approach for handling dependencies during a unit test is to "inject" them
         * into the constructor.
         * 
         * We learned of a concept called a Test Double. This works really well when you don't
         * need the class to do much other than to serve as a "body double" in place of the real one.
         */

        [TestMethod()]
        public void Index_HttpGet_LoadsAllMessages()
        {
            //Arrange
            var controller = new ForumController(new FormDoubleDAL());

            //Act
            var result = controller.Index() as ViewResult;

            //Assert
            // - Verify we get the index view back
            // - Verify that the model is a List<ForumPost>
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);
            Assert.IsNotNull(result.Model);
            Assert.IsTrue(result.Model is List<ForumPost>);
        }

        [TestMethod()]
        public void NewPost_HttpGet_LoadsView()
        {
            //Arrange
            var controller = new ForumController(new FormDoubleDAL());

            //Act
            var result = controller.NewPost() as ViewResult;

            //Assert
            Assert.IsNotNull(result);            
            Assert.AreEqual("NewPost", result.ViewName);
        }

        [TestMethod()]
        public void NewPost_HttpPost_RedirectsToIndex()
        {
            //Arrange
            var controller = new ForumController(new FormDoubleDAL());
            var model = new ForumPost();

            //Act
            var result = controller.NewPost(model) as RedirectToRouteResult;

            //Assert
            // - Check to see if it was a redirect result that was returned after
            // the user posted the new message.
            // - Check to make sure they are redirected back to the index action
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.RouteValues["action"]);
        }
    }
}