using EmployeePayroll.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of various workers
            List<IWorker> payrollEmployees = new List<IWorker>()
            {
                new SalariedWorker(120000, "Mouse", "Mickey"),
                new VolunteerWorker("Geef", "George"),
                new HourlyWorker(15, "Duck", "Donald"),
                new HourlyWorker(19.5, "Duck", "Daisy"),
                new SalariedWorker(170000, "Mouse", "Minnie")
            };

            // Print out the first row
            Console.WriteLine("Employee".PadRight(30) + "Hours Worked".PadRight(25) + "Pay".PadRight(10));

            // Variables to hold Count
            double totalHours = 0;
            double totalPay = 0.0;
            Random randomHourGenerator = new Random();

            foreach (IWorker worker in payrollEmployees)
            {
                int hoursWorked = randomHourGenerator.Next(10, 60);
                double pay = worker.CalculateWeeklyPay(hoursWorked);

                // Print the employee line out
                Console.Write($"{worker.LastName}, {worker.FirstName}".PadRight(30));
                Console.Write(hoursWorked.ToString().PadRight(25));
                Console.Write(pay.ToString("C").PadRight(10));
                Console.Write("\r\n");

                totalHours += hoursWorked;
                totalPay += pay;
            }

            // Print the last line out
            Console.WriteLine();
            Console.WriteLine("Total Hours: " + totalHours);
            Console.WriteLine("Total Pay: " + totalPay.ToString("C"));
            Console.WriteLine();
        }
    }
}
