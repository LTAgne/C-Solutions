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
    public class SPUTwoDayGroundTests
    {
        [TestMethod()]
        public void CalculateRateTest_SPUTwoDayGround()
        {
            SPUTwoDayGround spu = new SPUTwoDayGround();

            Assert.AreEqual(.050, spu.CalculateRate(15, 1));
            Assert.AreEqual(.100, spu.CalculateRate(17, 1));
        }
    }
}