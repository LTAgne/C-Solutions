using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll.Classes
{
    public class HourlyWorker : IWorker
    {
        private double hourlyRate;
        public double HourlyRate
        {
            get { return hourlyRate; }
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


        public HourlyWorker(double hourlyRate, string firstname, string lastname)
        {
            this.hourlyRate = hourlyRate;
            this.firstName = firstname;
            this.lastName = lastname;
        }

        /*
        * Time and a half for overtime
        * Otherwise its hourly rate * hours worked
        */
        public double CalculateWeeklyPay(int hoursWorked)
        {
            double pay = hourlyRate * hoursWorked;

            if (hoursWorked > 40)
            {
                double overtime = hoursWorked - 40;
                pay = pay + (hourlyRate * overtime * 0.5);
            }

            return pay;
        }
    }
}
