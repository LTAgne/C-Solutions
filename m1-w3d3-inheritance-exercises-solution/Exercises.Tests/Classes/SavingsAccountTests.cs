using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class SavingsAccountTests
    {
        [TestMethod]
        public void TryToWithdrawFromNegativeBalance()
        {
            SavingsAccount savAcct = new SavingsAccount("", "", new DollarAmount(-100));

            DollarAmount newBalance = savAcct.Withdraw(new DollarAmount(100));

            Assert.AreEqual(-100, newBalance.TotalAmountInCents);
            Assert.AreEqual(-100, savAcct.Balance.TotalAmountInCents);
        }

        [TestMethod]
        public void SendPositiveIntoNegativeTest()
        {
            SavingsAccount savAcct = new SavingsAccount("", "", new DollarAmount(100));

            DollarAmount newBalance = savAcct.Withdraw(new DollarAmount(200));

            Assert.AreEqual(100, newBalance.TotalAmountInCents);
            Assert.AreEqual(100, savAcct.Balance.TotalAmountInCents);
        }


        [TestMethod]
        public void TryToWithdrawFromPositiveBalance()
        {
            SavingsAccount savAcct = new SavingsAccount("", "", new DollarAmount(20000));

            DollarAmount newBalance = savAcct.Withdraw(new DollarAmount(1000));

            Assert.AreEqual(19000, newBalance.TotalAmountInCents);
            Assert.AreEqual(19000, savAcct.Balance.TotalAmountInCents);
        }

        [TestMethod]
        public void TryToWithdrawFromBalanceBelow150()
        {
            SavingsAccount savAcct = new SavingsAccount("", "", new DollarAmount(15100));

            DollarAmount newBalance = savAcct.Withdraw(new DollarAmount(1000));

            Assert.AreEqual(13900, newBalance.TotalAmountInCents);
            Assert.AreEqual(13900, savAcct.Balance.TotalAmountInCents);
        }
    }
}
