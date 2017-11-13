using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSGeek.Controllers;
using SSGeek.DAL;
using Moq;
using System.Web.Mvc;
using SSGeek.Models;

namespace SSGeekTests.Controllers
{
    [TestClass]
    public class ProductControllerTests
    {

        [TestMethod]
        public void ValidProductId_Returns_DetailView()
        {
            Mock<IProductDAL> mockDal = new Mock<IProductDAL>();
            mockDal.Setup(m => m.GetProduct(1)).Returns(new SSGeek.Models.Product()
            {
                ProductId = 1,
                Name = "Fake Product"
            });
            StoreController controller = new StoreController(mockDal.Object);


            var result = controller.Detail(1) as ViewResult;


            Assert.IsNotNull(result);
            Assert.AreEqual("Detail", result.ViewName);
            Assert.IsNotNull(result.Model);
        }

        [TestMethod]
        public void InvalidProductId_Returns_HttpNotFound()
        {
            Mock<IProductDAL> mockDal = new Mock<IProductDAL>();
            mockDal.Setup(m => m.GetProduct(It.IsAny<int>())).Returns<Product>(null);
            
            StoreController controller = new StoreController(mockDal.Object);

            var result = controller.Detail(1) as HttpNotFoundResult;

            Assert.IsNotNull(result);
        }


    }
}
