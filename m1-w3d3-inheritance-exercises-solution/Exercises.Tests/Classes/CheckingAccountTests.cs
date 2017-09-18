using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class CheckingAccountTests
    {
        [TestMethod]
        public void WithdrawNegativeWithFeeBalance_Test()
        {
            CheckingAccount chkAccount = new CheckingAccount("", "", new DollarAmount(-100));

            DollarAmount newBalance = chkAccount.Withdraw(new DollarAmount(100));

            Assert.AreEqual(-1200, newBalance.TotalAmountInCents);
            Assert.AreEqual(-1200, chkAccount.Balance.TotalAmountInCents);            
        }

        [TestMethod]
        public void WithdrawPositiveWithFee_Test()
        {
            CheckingAccount chkAccount = new CheckingAccount("", "", new DollarAmount(-100));

            DollarAmount newBalance = chkAccount.Withdraw(new DollarAmount(200));

            Assert.AreEqual(-1300, newBalance.TotalAmountInCents);
            Assert.AreEqual(-1300, chkAccount.Balance.TotalAmountInCents);
        }

        [TestMethod]
        public void WithdrawNegativeBalanceBelow100_Test()
        {
            CheckingAccount chkAccount = new CheckingAccount("", "", new DollarAmount(-10000));

            DollarAmount newBalance = chkAccount.Withdraw(new DollarAmount(200));

            Assert.AreEqual(-10000, newBalance.TotalAmountInCents);
            Assert.AreEqual(-10000, chkAccount.Balance.TotalAmountInCents);
        }

        [TestMethod]
        public void WithdrawPositiveBalance_Test()
        {
            CheckingAccount chkAccount = new CheckingAccount("", "", new DollarAmount(1000));

            DollarAmount newBalance = chkAccount.Withdraw(new DollarAmount(500));

            Assert.AreEqual(500, newBalance.TotalAmountInCents);
            Assert.AreEqual(500, chkAccount.Balance.TotalAmountInCents);
        }
    }
}
