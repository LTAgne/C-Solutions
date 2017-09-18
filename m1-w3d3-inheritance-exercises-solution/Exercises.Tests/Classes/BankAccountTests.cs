using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void NewCustomerHasZeroBalance()
        {
            BankAccount account = new BankAccount("", "");
            Assert.AreEqual(0, account.Balance.TotalAmountInCents);            
        }

        [TestMethod]
        public void NewCustomerHasStartingBalance()
        {
            BankAccount account = new BankAccount("", "", new DollarAmount(100));
            Assert.AreEqual(100, account.Balance.TotalAmountInCents);    
        }

        [TestMethod]
        public void DepositIncreasesBalance()
        {
            BankAccount account = new BankAccount("", "");

            DollarAmount newBalance= account.Deposit(new DollarAmount(100));

            Assert.AreEqual(100, newBalance.TotalAmountInCents);
            Assert.AreEqual(100, account.Balance.TotalAmountInCents);
        }

        [TestMethod]
        public void WithdrawDecreasesBalance()
        {
            BankAccount account = new BankAccount("", "");

            DollarAmount newBalance = account.Withdraw(new DollarAmount(100));

            Assert.AreEqual(-100, newBalance.TotalAmountInCents);
            Assert.AreEqual(-100, account.Balance.TotalAmountInCents);
        }

        [TestMethod]
        public void TransferTests()
        {
            BankAccount source = new BankAccount("", "", new DollarAmount(5000));
            BankAccount destination = new BankAccount("", "");

            DollarAmount newSourceBalance = source.TransferTo(destination, new DollarAmount(2400));

            Assert.AreEqual(2600, newSourceBalance.TotalAmountInCents);
            Assert.AreEqual(2400, destination.Balance.TotalAmountInCents);
            Assert.AreEqual(2600, source.Balance.TotalAmountInCents);
        }
    }
}
