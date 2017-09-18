using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountHolder, string accountNumber, DollarAmount balance)
            : base(accountHolder, accountNumber, balance)
        {
        }

        public CheckingAccount(string accountHolder, string accountNumber)
            : base(accountHolder, accountNumber)
        { }

        public override DollarAmount Withdraw(DollarAmount amountToWithdraw)
        {
            // Only allow the withdraw if the balance isn't going to go below -$100
            if (Balance.Minus(amountToWithdraw).Dollars > -100)
            {
                // Withdraw the $$
                base.Withdraw(amountToWithdraw);

                // If the balance dips below 0, assess $10 charge
                if (Balance.IsNegative)
                {
                    base.Withdraw(new DollarAmount(10, 00));
                }
            }

            return Balance;            
        }
    }
}
