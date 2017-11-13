using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSGeek.Controllers;
using SSGeek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SSGeek.Controllers.Tests
{
    [TestClass()]
    public class TriviaControllerTests
    {
        [TestMethod()]
        public void Index_HttpGet_CorrectlyReturnsRightView()
        {
            var controller = new TriviaController();

            var result = controller.Index();            

            // Assert the output
            Assert.IsNotNull(result);
            Assert.IsTrue(result is ViewResult);

            var viewResult = result as ViewResult;

            // Assert the View and Model
            Assert.AreEqual("Index", viewResult.ViewName);
            Assert.IsNotNull(viewResult.Model);
            Assert.IsTrue(viewResult.Model is TriviaModel);
        }

        [TestMethod()]
        public void Index_HttpPost_CorrectlyRedirectsToRightView()
        {
            //Arrange
            var model = new TriviaModel
            {
                SubmittedAnswer = "Neil Armstrong"
            };
            var controller = new TriviaController();

            //Act
            var result = controller.Index(model);

            //Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result is RedirectToRouteResult);

            var redirectResult = result as RedirectToRouteResult;

            //Assert the right action is redirected
            Assert.AreEqual("Correct", redirectResult.RouteValues["action"]);            
        }

        [TestMethod()]
        public void Index_HttpPost_CorrectlyRedirectsToIncorrectView()
        {
            //Arrange
            var model = new TriviaModel
            {
                SubmittedAnswer = "Tom Hanks"
            };
            var controller = new TriviaController();

            //Act
            var result = controller.Index(model);

            //Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result is RedirectToRouteResult);

            var redirectResult = result as RedirectToRouteResult;

            //Assert the right action is redirected
            Assert.AreEqual("Incorrect", redirectResult.RouteValues["action"]);
        }    
    }
}