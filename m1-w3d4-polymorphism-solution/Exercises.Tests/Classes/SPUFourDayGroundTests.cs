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
    public class SPUFourDayGroundTests
    {
        [TestMethod()]
        public void CalculateRateTest_SPUFourDayGround()
        {
            SPUFourDayGround spu = new SPUFourDayGround();

            Assert.AreEqual(.0050, spu.CalculateRate(15, 1));
            Assert.AreEqual(.0100, spu.CalculateRate(17, 1));
        }
    }
}