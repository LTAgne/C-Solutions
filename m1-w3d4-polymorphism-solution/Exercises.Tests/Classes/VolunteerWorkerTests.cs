using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayroll.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll.Classes.Tests
{
    [TestClass()]
    public class VolunteerWorkerTests
    {
        [TestMethod()]
        public void CalculateWeeklyPay_AlwaysExpectZero()
        {
            VolunteerWorker vw = new VolunteerWorker("John", "Doe");

            Assert.AreEqual(0, vw.CalculateWeeklyPay(0));
            Assert.AreEqual(0, vw.CalculateWeeklyPay(20));
            Assert.AreEqual(0, vw.CalculateWeeklyPay(40));
        }
    }
}