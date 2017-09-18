using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes.Tests
{
    [TestClass()]
    public class DollarAmountTests
    {
        [TestMethod()]
        public void ToStringTest()
        {            
            Assert.AreEqual("$1.50", new DollarAmount(150).ToString());
            Assert.AreEqual("$1.00", new DollarAmount(100).ToString());
            Assert.AreEqual("$1.05", new DollarAmount(105).ToString());

        }
    }
}