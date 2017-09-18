using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class BankCustomer
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private List<BankAccount> accounts = new List<BankAccount>();
        public BankAccount[] Accounts
        {
            get { return accounts.ToArray(); }
        }

        public bool IsVip
        {
            get
            {
                DollarAmount totalBalance = new DollarAmount(0);

                foreach (BankAccount account in accounts)
                {
                    totalBalance = totalBalance.Plus(account.Balance);
                }

                return totalBalance.Dollars >= 25000;
            }
        }

        public void AddAccount(BankAccount newAccount)
        {
            accounts.Add(newAccount);
        }

    }
}
