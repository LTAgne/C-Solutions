using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TollBoothCalculator.Classes;

namespace TollBoothCalculator.Tests.Classes
{
    [TestClass]
    public class CalculateTollCarTests
    {
        [TestMethod]
        public void CalculateToll_CarWithoutTrailerTests()
        {
            Car car = new Car(false);
            Assert.AreEqual("Car", car.Type);
            Assert.AreEqual(false, car.HasTrailer);
            Assert.AreEqual(0.020, car.CalculateToll(1), 0.001);
            Assert.AreEqual(0.20, car.CalculateToll(10), 0.001);
            Assert.AreEqual(2.0, car.CalculateToll(100), 0.001);
        }

        [TestMethod]
        public void CalculateToll_CarWithTrailerTests()
        {
            Car car = new Car(true);
            Assert.AreEqual("Car", car.Type);
            Assert.AreEqual(true, car.HasTrailer);
            Assert.AreEqual(1.020, car.CalculateToll(1), 0.001);
            Assert.AreEqual(1.20, car.CalculateToll(10), 0.001);
            Assert.AreEqual(3.0, car.CalculateToll(100), 0.001);
        }
    }
}
