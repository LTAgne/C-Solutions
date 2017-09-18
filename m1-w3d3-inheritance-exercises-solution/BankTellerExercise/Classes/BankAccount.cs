using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        private string accountHolderName;
        public string AccountHolderName
        {
            get { return accountHolderName; }
            set { accountHolderName = value; }
        }

        private string accountNumber;
        public string AccountNumber
        {
            get { return accountNumber; }            
        }

        private DollarAmount balance;
        public DollarAmount Balance
        {            
            get { return balance; }            
        }

        // Constructor
        public BankAccount(string accountHolder, string accountNumber)
        {
            this.accountHolderName = accountHolder;
            this.accountNumber = accountNumber;
            this.balance = new DollarAmount(0);
        }

        public BankAccount(string accountHolder, string accountNumber, DollarAmount balance)
        {
            this.accountHolderName = accountHolder;
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        // Update the balance by using the DollarAmount.Plus method
        public DollarAmount Deposit(DollarAmount amountToDeposit)
        {
            balance = balance.Plus(amountToDeposit);
            return balance;
        }

        // Update the balance by using the DollarAmount.Minus method
        public virtual DollarAmount Withdraw(DollarAmount amountToWithdraw)
        {
            balance = balance.Minus(amountToWithdraw);
            return balance;
        }

        public DollarAmount TransferTo(BankAccount destination, DollarAmount amountToTransfer)
        {
            this.Withdraw(amountToTransfer);
            destination.Deposit(amountToTransfer);

            return balance;
        }

    }
}
