using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Employee
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private string department;
        private double annualSalary;


        /// <summary>
        /// Employee Id
        /// </summary>
        public int EmployeeId
        {
            get { return employeeId; }
        }

        /// <summary>
        /// Employee Name
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
        }

        /// <summary>
        /// Employee last name
        /// </summary>
        public string LastName
        {
            get { return lastName; } 
            set { lastName = value; }       
        }

        public string FullName
        {
            get { return $"{LastName}, {FirstName}"; }
        }

        /// <summary>
        /// Department
        /// </summary>
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        /// <summary>
        /// Annual Employee Salary
        /// </summary>
        public double AnnualSalary
        {
            get { return annualSalary; }        
        }

        /// <summary>
        /// Creates a new employee
        /// </summary>
        /// <param name="name">Employee name</param>
        /// <param name="salary"></param>
        public Employee(int employeeId, string firstName, string lastName, double salary)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.annualSalary = salary;
        }

        /// <summary>
        /// Provides the employee a percentage-based raise
        /// </summary>
        /// <param name="percentage">number-based percentage to raise salary by</param>
        public void RaiseSalary(double percentage)
        {
            double raiseAmount = annualSalary * Math.Abs(percentage/100.00);
            annualSalary += raiseAmount;
        }
    }
}
