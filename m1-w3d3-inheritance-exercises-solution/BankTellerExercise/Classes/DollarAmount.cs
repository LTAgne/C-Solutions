using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    // DollarAmount is an immutable type. Meaning it will not change its value
    // Any operation will return a new DollarAmount. We don't want you or our other users
    // changing the value of a DollarAmount and having the bank account balance update as a result.
    public class DollarAmount : IComparable<DollarAmount>
    {
        private int totalAmountInCents;
        
        public int TotalAmountInCents
        {
            get { return totalAmountInCents; }
        }

        /// <summary>
        /// Number of cents
        /// </summary>
        public int Cents
        {
            get
            {
                // Get the cents after the decimal point
                // 150 cents is $1.50 and therefore 50 cents returned
                int remainder = totalAmountInCents % 100;
                return remainder;
            }
        }

        /// <summary>
        /// Total number of dollars
        /// </summary>
        public int Dollars
        {
            get
            {
                // Get the cents before decimal point
                // Divide by 100 to get 1
                int quotient = totalAmountInCents / 100;
                return quotient;
            }
        }

        /// <summary>
        /// If DollarAmount is negative value
        /// </summary>
        /// <returns></returns>
        public bool IsNegative
        {
            get
            {
                return totalAmountInCents < 0;
            }
        }

        /// <summary>
        /// Constructor for DollarAmount
        /// </summary>
        /// <param name="totalCents">Given total cents</param>
        public DollarAmount(int totalCents)
        {
            // Set total amount in cents to parameter
            totalAmountInCents = totalCents;
        }

        /// <summary>
        /// Second constructor for dollaramouns
        /// </summary>
        /// <param name="dollars">Amount of dollars</param>
        /// <param name="cents">Amount of cents</param>
        public DollarAmount(int dollars, int cents)
        {
            totalAmountInCents = (dollars * 100) + cents;
        }

       

        /// <summary>
        /// Subtract one dollar amount from another dollar amount
        /// </summary>
        /// <param name="amountToSubtract"></param>
        /// <returns>New Dollar Amount Value</returns>
        public DollarAmount Minus(DollarAmount amountToSubtract)
        {
            int difference = this.totalAmountInCents - amountToSubtract.totalAmountInCents;

            return new DollarAmount(difference);
        }

        /// <summary>
        /// Adds one dollar amound to another dollar amount
        /// </summary>
        /// <param name="amountToAdd"></param>
        /// <returns>New Dollar Amount Value</returns>
        public DollarAmount Plus(DollarAmount amountToAdd)
        {            
            int newTotal = this.totalAmountInCents + amountToAdd.totalAmountInCents;

            return new DollarAmount(newTotal);
        }




        /// <summary>
        /// IComparable Implentation
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(DollarAmount other)
        {
            if(this.totalAmountInCents < other.totalAmountInCents)
            {
                return -1;
            }
            else if (other.totalAmountInCents < this.totalAmountInCents)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        // Exercise 1: Override ToString()
        public override string ToString()
        {
            return (totalAmountInCents / 100.00).ToString("C");
            
        }
    }
}
