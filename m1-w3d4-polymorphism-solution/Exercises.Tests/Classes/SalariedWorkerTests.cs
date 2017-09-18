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
    public class SalariedWorkerTests
    {
        [TestMethod()]
        public void CalculateWeeklyPay_SalaryBased_RegardlessOfTime()
        {
            //Arrange
            SalariedWorker sw = new SalariedWorker(52000, "John", "Doe");

            //Assert
            Assert.AreEqual(1000, sw.CalculateWeeklyPay(0));
            Assert.AreEqual(1000, sw.CalculateWeeklyPay(20));
            Assert.AreEqual(1000, sw.CalculateWeeklyPay(40));
            Assert.AreEqual(1000, sw.CalculateWeeklyPay(60));

        }
    }
}