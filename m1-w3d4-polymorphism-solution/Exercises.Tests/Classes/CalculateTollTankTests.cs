using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TollBoothCalculator.Classes;

namespace TollBoothCalculator.Classes.Tests
{
    [TestClass]
    public class TankTests
    {
        [TestMethod]
        public void CalculateToll_TankTests()
        {
            Tank tank = new Tank();
            Assert.AreEqual("Tank", tank.Type);
            Assert.AreEqual(0.0, tank.CalculateToll(0), 0.001);
            Assert.AreEqual(0.0, tank.CalculateToll(100), 0.001);
            Assert.AreEqual(0.0, tank.CalculateToll(1000), 0.001);
        }
    }
}
