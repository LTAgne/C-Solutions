using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll.Classes
{
    public interface IWorker
    {
        string FirstName { get; }
        string LastName { get; }

        double CalculateWeeklyPay(int hoursWorked);
    }
}
