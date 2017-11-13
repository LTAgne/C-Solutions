using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSGeek.Controllers;
using System.Web.Mvc;
using SSGeek.Models;

namespace SSGeekTests.Controllers
{
    [TestClass]
    public class CalculatorControllerTests
    {
        /*
         * The goal of controller unit tests for this controller is to ensure that the controller
         * action returns the right view and the correct model.
         * 
         * It is really easy for developers to change the controller action view or model. This test
         * ensures that it is something deliberately being done to avoid a downstream effect.
         * 
         * There are no dependencies so we do not need any type of dependency injection.
         */ 

        [TestMethod]
        public void AlienAge_HttpGet_ReturnsAlienAgeView()
        {
            CalculatorsController controller = new CalculatorsController();

            ViewResult result = controller.AlienAge() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("AlienAge", result.ViewName);
            Assert.IsNotNull(result.Model);
            Assert.IsTrue(result.Model is AlienAgeModel);
        }

        [TestMethod]
        public void AlienAgeResult_HttpGet_ReturnsAlienAgeResultView()
        {
            CalculatorsController controller = new CalculatorsController();

            ViewResult result = controller.AlienAgeResult(new AlienAgeModel()) as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("AlienAgeResult", result.ViewName);
            Assert.IsNotNull(result.Model);
            Assert.IsTrue(result.Model is AlienAgeModel);
        }

        [TestMethod]
        public void AlienWeight_HttpGet_ReturnsAlienWeightView()
        {
            CalculatorsController controller = new CalculatorsController();

            ViewResult result = controller.AlienWeight() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("AlienWeight", result.ViewName);
            Assert.IsNotNull(result.Model);
            Assert.IsTrue(result.Model is AlienWeightModel);
        }

        [TestMethod]
        public void AlienWeight_HttpGet_ReturnsAlienWeightResultView()
        {
            CalculatorsController controller = new CalculatorsController();

            ViewResult result = controller.AlienWeightResult(new AlienWeightModel()) as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("AlienWeightResult", result.ViewName);
            Assert.IsNotNull(result.Model);
            Assert.IsTrue(result.Model is AlienWeightModel);
        }

        [TestMethod]
        public void AlienTravel_HttpGet_ReturnsAlienTravelView()
        {
            CalculatorsController controller = new CalculatorsController();

            ViewResult result = controller.AlienTravel() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("AlienTravel", result.ViewName);
            Assert.IsNotNull(result.Model);
            Assert.IsTrue(result.Model is AlienTravelModel);
        }

        [TestMethod]
        public void AlienTravelResult_HttpGet_ReturnsAlienTravelResultView()
        {
            CalculatorsController controller = new CalculatorsController();

            ViewResult result = controller.AlienTravelResult(new AlienTravelModel()) as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("AlienTravelResult", result.ViewName);
            Assert.IsNotNull(result.Model);
            Assert.IsTrue(result.Model is AlienTravelModel);

        }

    }
}
