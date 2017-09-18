using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll.Classes
{
    public class SalariedWorker : IWorker
    {
        private double annualSalary;
        public double AnnualSalary
        {
            get { return annualSalary; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        public SalariedWorker(double annualSalary, string firstname, string lastname)
        {
            this.annualSalary = annualSalary;
            this.firstName = firstname;
            this.lastName = lastname;
        }

        /*
        * Weekly pay for salary worker is annual pay over 52 weeks
        */
        public double CalculateWeeklyPay(int hoursWorked)
        {
            return this.annualSalary / 52;
        }
    }
}
