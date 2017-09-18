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
    public class PostalServiceThirdClassTests
    {
        [TestMethod()]
        public void CalculateRateTest_PostalServiceThirdClass()
        {
            PostalServiceThirdClass psfc = new PostalServiceThirdClass();

            Assert.AreEqual(0.0020, psfc.CalculateRate(1, 1));
            Assert.AreEqual(0.0022, psfc.CalculateRate(5, 1));
            Assert.AreEqual(0.0024, psfc.CalculateRate(14, 1));
            Assert.AreEqual(0.0150, psfc.CalculateRate(36, 1));
            Assert.AreEqual(0.0160, psfc.CalculateRate(62, 1));
            Assert.AreEqual(0.0170, psfc.CalculateRate(144, 1));
        }
    }
}