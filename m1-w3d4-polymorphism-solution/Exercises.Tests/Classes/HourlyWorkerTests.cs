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
    public class HourlyWorkerTests
    {
        [TestMethod()]
        public void CalculateWeekly_0Hours_0Pay()
        {
            HourlyWorker hw = new HourlyWorker(1.0, "John", "Doe");

            Assert.AreEqual(0, hw.CalculateWeeklyPay(0));
        }

        [TestMethod()]
        public void CalculateWeekly_RegularTime()
        {
            HourlyWorker hw = new HourlyWorker(1.0, "John", "Doe");

            Assert.AreEqual(1, hw.CalculateWeeklyPay(1));
            Assert.AreEqual(20, hw.CalculateWeeklyPay(20));
            Assert.AreEqual(40, hw.CalculateWeeklyPay(40));            
        }

        [TestMethod]
        public void CalculateWeeklyPay_OverTime()
        {
            HourlyWorker hw = new HourlyWorker(1.0, "John", "Doe");

            Assert.AreEqual(41.5, hw.CalculateWeeklyPay(41));
            Assert.AreEqual(70, hw.CalculateWeeklyPay(60));
        }
    }
}