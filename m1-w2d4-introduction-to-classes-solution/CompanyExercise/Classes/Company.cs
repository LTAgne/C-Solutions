using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Company
    {        
        private string name;
        private int numberOfEmployees;
        private decimal revenue;
        private decimal expenses;

        public string Name
        {
            get { return this.name; }            
        }        

        public int NumberOfEmployees
        {
            get { return this.numberOfEmployees; }
            set { this.numberOfEmployees = value; }
        }

        public decimal Revenue
        {
            get { return this.revenue; }
            set { this.revenue = value; }
        }

        public decimal Expenses
        {
            get { return this.expenses; }
            set { this.expenses = value; }
        }

        public Company(string startingName)
        {
            this.name = startingName;
        }

        public string GetCompanySize()
        {
            if (this.numberOfEmployees < 50)
            {
                return "small";
            }
            else if (this.numberOfEmployees >= 50 && this.numberOfEmployees <= 250)
            {
                return "medium";
            }
            else
            {
                return "large";
            }
        }

        public decimal GetProfit()
        {
            return this.revenue - this.expenses;
        }

    }
}
