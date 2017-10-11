using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDB.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public string JobTitle { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public DateTime HireDate { get; set; }

        public override string ToString()
        {
            return EmployeeId.ToString().PadRight(5) + (LastName + ", " + FirstName).PadRight(30) + JobTitle.PadRight(30) + Gender.PadRight(3) + BirthDate.ToShortDateString().PadRight(10);
        }
    }
}
