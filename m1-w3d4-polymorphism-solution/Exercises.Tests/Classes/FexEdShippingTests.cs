using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostageCalculator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes.Tests
{
    [TestClass()]
    public class FexEdShippingTests
    {
        [TestMethod()]
        public void CalculateRateTest_FexEdShipping()
        {
            FexEdShipping fs = new FexEdShipping();

            Assert.AreEqual(20, fs.CalculateRate(16, 100));
            Assert.AreEqual(25, fs.CalculateRate(16, 501));
            Assert.AreEqual(23, fs.CalculateRate(49, 100));
            Assert.AreEqual(28, fs.CalculateRate(49, 501));
        }
    }
}