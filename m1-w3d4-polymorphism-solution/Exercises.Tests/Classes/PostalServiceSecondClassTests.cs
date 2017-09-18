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
    public class PostalServiceSecondClassTests
    {
        [TestMethod()]
        public void CalculateRateTest_PostalServiceSecondClass()
        {
            PostalServiceSecondClass psfc = new PostalServiceSecondClass();

            Assert.AreEqual(0.0035, psfc.CalculateRate(1, 1));
            Assert.AreEqual(0.0040, psfc.CalculateRate(5, 1));
            Assert.AreEqual(0.0047, psfc.CalculateRate(14, 1));
            Assert.AreEqual(0.0195, psfc.CalculateRate(36, 1));
            Assert.AreEqual(0.0450, psfc.CalculateRate(62, 1));
            Assert.AreEqual(0.0500, psfc.CalculateRate(144, 1));
        }
    }
}