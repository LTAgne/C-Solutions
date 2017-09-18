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
    public class PostalServiceFirstClassTests
    {
        [TestMethod()]
        public void CalculateRateTest_PostalServiceFirstClass()
        {
            PostalServiceFirstClass psfc = new PostalServiceFirstClass();

            Assert.AreEqual(0.035, psfc.CalculateRate(1, 1));
            Assert.AreEqual(0.040, psfc.CalculateRate(5, 1));
            Assert.AreEqual(0.047, psfc.CalculateRate(14, 1));
            Assert.AreEqual(0.195, psfc.CalculateRate(36, 1));
            Assert.AreEqual(0.450, psfc.CalculateRate(62, 1));
            Assert.AreEqual(0.500, psfc.CalculateRate(144, 1));
        }
    }
}