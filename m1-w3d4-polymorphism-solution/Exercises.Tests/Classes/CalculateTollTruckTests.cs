using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TollBoothCalculator.Classes;

namespace Exercises.Tests.Classes
{
    [TestClass]
    public class CalculateTollTruckTests
    {
        [TestMethod]
        public void CalculateToll_TruckWith8AxlesTests()
        {
            Truck truck = new Truck(8);
            Assert.AreEqual("Truck", truck.Type);
            Assert.AreEqual(8, truck.NumberOfAxles);
            Assert.AreEqual(0.048, truck.CalculateToll(1), 0.001);
            Assert.AreEqual(0.48, truck.CalculateToll(10), 0.001);
            Assert.AreEqual(4.80, truck.CalculateToll(100), 0.001);
        }

        [TestMethod]
        public void CalculateToll_TruckWithMoreThan8AxlesTests()
        {
            Truck truck = new Truck(9);
            Assert.AreEqual("Truck", truck.Type);
            Assert.AreEqual(9, truck.NumberOfAxles);
            Assert.AreEqual(0.048, truck.CalculateToll(1), 0.001);
            Assert.AreEqual(0.48, truck.CalculateToll(10), 0.001);
            Assert.AreEqual(4.80, truck.CalculateToll(100), 0.001);
        }

        [TestMethod]
        public void CalculateToll_TruckWith6AxlesTests()
        {
            Truck truck = new Truck(6);
            Assert.AreEqual("Truck", truck.Type);
            Assert.AreEqual(6, truck.NumberOfAxles);
            Assert.AreEqual(0.045, truck.CalculateToll(1), 0.001);
            Assert.AreEqual(0.45, truck.CalculateToll(10), 0.001);
            Assert.AreEqual(4.50, truck.CalculateToll(100), 0.001);
        }

        [TestMethod]
        public void CalculateToll_TruckWithMoreThan6ButLessThan8AxlesTests()
        {
            Truck truck = new Truck(7);
            Assert.AreEqual("Truck", truck.Type);
            Assert.AreEqual(7, truck.NumberOfAxles);
            Assert.AreEqual(0.045, truck.CalculateToll(1), 0.001);
            Assert.AreEqual(0.45, truck.CalculateToll(10), 0.001);
            Assert.AreEqual(4.50, truck.CalculateToll(100), 0.001);
        }

        [TestMethod]
        public void CalculateToll_TruckWith4AxlesTests()
        {
            Truck truck = new Truck(4);
            Assert.AreEqual("Truck", truck.Type);
            Assert.AreEqual(4, truck.NumberOfAxles);
            Assert.AreEqual(0.040, truck.CalculateToll(1), 0.001);
            Assert.AreEqual(0.40, truck.CalculateToll(10), 0.001);
            Assert.AreEqual(4.00, truck.CalculateToll(100), 0.001);
        }

        [TestMethod]
        public void CalculateToll_TruckWithMoreThan4ButLessThan6AxlesTests()
        {
            Truck truck = new Truck(5);
            Assert.AreEqual("Truck", truck.Type);
            Assert.AreEqual(5, truck.NumberOfAxles);
            Assert.AreEqual(0.040, truck.CalculateToll(1), 0.001);
            Assert.AreEqual(0.40, truck.CalculateToll(10), 0.001);
            Assert.AreEqual(4.00, truck.CalculateToll(100), 0.001);
        }

        [TestMethod]
        public void CalculateToll_TruckWithLessThan4AxlesTests()
        {
            Truck truck = new Truck(3);
            Assert.AreEqual("Truck", truck.Type);
            Assert.AreEqual(3, truck.NumberOfAxles);
            Assert.AreEqual(0.040, truck.CalculateToll(1), 0.001);
            Assert.AreEqual(0.40, truck.CalculateToll(10), 0.001);
            Assert.AreEqual(4.00, truck.CalculateToll(100), 0.001);
        }
    }
}
