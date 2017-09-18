using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll.Classes
{
    public class VolunteerWorker : IWorker
    {
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


        public VolunteerWorker(string firstname, string lastname)
        {
            this.firstName = firstname;
            this.lastName = lastname;
        }

        public double CalculateWeeklyPay(int hoursWorked)
        {
            return 0;
        }
    }
}
