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
    public class SPUNextDayGroundTests
    {
        [TestMethod()]
        public void CalculateRateTest_SPUNextDayGround()
        {
            SPUNextDayGround spu = new SPUNextDayGround();

            Assert.AreEqual(0.075, spu.CalculateRate(15, 1));
            Assert.AreEqual(.150, spu.CalculateRate(17, 1));

        }
    }
}