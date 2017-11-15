using Microsoft.VisualStudio.TestTools.UnitTesting;
using Critter.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Critter.Web.DataAccess;
using Critter.Web.Models.Data;
using System.Web.Mvc;

namespace Critter.Web.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        private Mock<IUserDAL> mockUserDal = new Mock<IUserDAL>();
        private Mock<IMessageDAL> mockMessageDal = new Mock<IMessageDAL>();

        

        [TestMethod()]
        public void HomeControllerTest()
        {
            mockMessageDal.Setup(m => m.GetPublicMessages(It.IsAny<int>())).Returns(new List<Message>());
            var controller = new HomeController(mockUserDal.Object, mockMessageDal.Object);

            var result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
            var model = result.Model as List<Message>;
            Assert.IsNotNull(model);
            Assert.AreEqual("Index", result.ViewName);

        }
    }
}