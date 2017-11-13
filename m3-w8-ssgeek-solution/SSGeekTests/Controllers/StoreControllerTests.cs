using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SSGeek.Controllers;
using SSGeek.DAL;
using SSGeek.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web;
using System.Web.Routing;

namespace SSGeekTests.Controllers
{
    [TestClass]
    public class StoreControllerTests
    {
        /*
         * The unit tests for Store Controller are a bit more difficult.
         * The controller not only has a dependency on the ProductDAL, but it also
         * relies on Session. With Session it is very complicated to create a "Test Double"
         * 
         * Developers will often rely on a concept called Mocking to write their unit tests.
         * It is less work than a Test Double, allows us to simulate how a dependency behaves
         * only for a single method, but it can be a bit more complicated.
         * 
         * FYI: This gets really tricky and complex. You may learn it on the job
         * you may end up at a company that uses a different approach.
         */

        [TestMethod]
        public void Index_HttpGet_ReturnsIndexViewOfProducts()
        {
            //Arrange
            // Mock our ProductDAL to return back a list of products
            Mock<IProductDAL> mockDal = new Mock<IProductDAL>();
            mockDal.Setup(m => m.GetProducts()).Returns(new List<Product>());

            StoreController controller = new StoreController(mockDal.Object);

            //Act
            ViewResult result = controller.Index() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);
            Assert.IsNotNull(result.Model);
        }

        [TestMethod]
        public void Detail_HttpGet_ReturnsDetailViewForValidId()
        {
            //Arrange
            //Mock our DAL to return a Product for any Id
            Product fakeProduct = new Product()
            {
                ProductId = 1,
                Name = "Fake Product"
            };
            Mock<IProductDAL> mockDal = new Mock<IProductDAL>();
            mockDal.Setup(m => m.GetProduct(1)).Returns(fakeProduct);
            // The above line reads
            // "When GetProduct is called on the IProductDAL, with the integer 1, return a 
            // fake product with id 1."
            StoreController controller = new StoreController(mockDal.Object);

            //Act
            ViewResult result = controller.Detail(1) as ViewResult;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Detail", result.ViewName);
            Assert.AreEqual(fakeProduct, result.Model);
        }

        [TestMethod]
        public void Detail_HttpGet_Returns404ForInvalidId()
        {
            //Arrange
            Mock<IProductDAL> mockDal = new Mock<IProductDAL>();
            mockDal.Setup(m => m.GetProduct(It.IsAny<int>())).Returns<Product>(null);
            // The above line reads
            // "When GetProduct is called on the IProductDAL, for any integer, return null."
            StoreController controller = new StoreController(mockDal.Object);

            //Act
            HttpNotFoundResult result = controller.Detail(1) as HttpNotFoundResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AddToCart_HttpPost_AddsItemToNewCart()
        {
            //Arrange
            Product fakeProduct = new Product();
            Mock<IProductDAL> productDal = new Mock<IProductDAL>();
            productDal.Setup(m => m.GetProduct(It.IsAny<int>())).Returns(fakeProduct);

            StoreController controller = new StoreController(productDal.Object);

            // Now we need to mock session for our controller
            // It has been moved to another method
            AddMockSessionToController(controller, null);

            //Act
            RedirectToRouteResult redirectResult = controller.AddToCart(1, 1) as RedirectToRouteResult;

            //Assert
            Assert.IsNotNull(redirectResult);
            Assert.AreEqual("ViewCart", redirectResult.RouteValues["action"]);

            ShoppingCart cart = controller.Session["ShoppingCart"] as ShoppingCart;
            Assert.AreEqual(1, cart.Items.Count);
        }

        [TestMethod]
        public void AddToCart_HttpPost_AddsITemToExistingCart()
        {
            //Arrange            
            Product fakeProduct = new Product() { ProductId = 1 };
            Product existingItem = new Product() { ProductId = 999 };
            ShoppingCart existingCart = new ShoppingCart();
            existingCart.AddOrUpdateCart(existingItem, 1);

            Mock<IProductDAL> productDal = new Mock<IProductDAL>();
            productDal.Setup(m => m.GetProduct(It.IsAny<int>())).Returns(fakeProduct);

            StoreController controller = new StoreController(productDal.Object);

            // Now we need to mock session for our controller
            // It has been moved to another method
            AddMockSessionToController(controller, existingCart);

            //Act
            RedirectToRouteResult redirectResult = controller.AddToCart(1, 1) as RedirectToRouteResult;

            //Assert
            Assert.IsNotNull(redirectResult);
            Assert.AreEqual("ViewCart", redirectResult.RouteValues["action"]);
            Assert.AreEqual(2, existingCart.Items.Count);
        }

        [TestMethod]
        public void AddToCart_HttpPost_Returns404ForInvalidId()
        {
            //Arrange
            Mock<IProductDAL> productDal = new Mock<IProductDAL>();
            productDal.Setup(m => m.GetProduct(It.IsAny<int>())).Returns<Product>(null);

            StoreController controller = new StoreController(productDal.Object);

            //Act
            HttpNotFoundResult result = controller.Detail(1) as HttpNotFoundResult;

            //Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void ViewCart_HttpGet_ReturnsExistingCart()
        {
            //Arrange
            ShoppingCart existingCart = new ShoppingCart();
            StoreController controller = new StoreController(null);

            AddMockSessionToController(controller, existingCart);

            //Act
            ViewResult result = controller.ViewCart() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("ViewCart", result.ViewName);
            Assert.AreEqual(existingCart, result.Model);
        }

        [TestMethod]
        public void ViewCart_HttpGet_ReturnsNewCart()
        {
            StoreController controller = new StoreController(null);

            AddMockSessionToController(controller, null);

            //Act
            ViewResult result = controller.ViewCart() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("ViewCart", result.ViewName);
            Assert.IsNotNull(result.Model);
        }

        private void AddMockSessionToController(StoreController controller, ShoppingCart cart)
        {
            // Mock Session Object
            MockSession mockSession = new MockSession();

            mockSession["ShoppingCart"] = cart;

            // Mock Http Context Request for Controller
            // because Session doesn't exist unless MVC actually receives a "request"
            Mock<HttpContextBase> mockContext = new Mock<HttpContextBase>();

            // When the Controller calls this.Session it will get a mock session
            mockContext.Setup(c => c.Session).Returns(mockSession);

            // Assign the context property on the controller to our mock context which uses our mock session
            controller.ControllerContext = new ControllerContext(mockContext.Object, new RouteData(), controller);

            // For more details: 
            // https://dontpaniclabs.com/blog/post/2011/03/22/testing-session-in-mvc-in-four-lines-of-code/
        }

        private class MockSession : HttpSessionStateBase
        {
            Dictionary<string, object> sessionDictionary = new Dictionary<string, object>();
            public override object this[string name]
            {
                get { return sessionDictionary[name]; }
                set { sessionDictionary[name] = value; }
            }
        }
    }
}
