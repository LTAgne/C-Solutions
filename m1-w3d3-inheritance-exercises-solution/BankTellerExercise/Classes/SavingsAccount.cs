using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountHolder, string accountNumber, DollarAmount balance)
            :base(accountHolder, accountNumber, balance)
        {
        }

        public SavingsAccount(string accountHolder, string accountNumber)
            : base(accountHolder, accountNumber)
        { }

        public override DollarAmount Withdraw(DollarAmount amountToWithdraw)
        {
            // only perform transaction of positive $
            if (!Balance.Minus(amountToWithdraw).IsNegative)
            {
                base.Withdraw(amountToWithdraw);

                // Assess $2 fee if it goes below $150
                if (Balance.Dollars < 150)
                {
                    base.Withdraw(new DollarAmount(200));
                }                
            }

            return Balance;

        }
    }
}
