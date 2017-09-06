using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeChange
{
    class Program
    {
        /*
        Write a command line program which prompts the user for the total bill, and the amount tendered. It should then display the change required.
 
        C:\Users> MakeChange
         
        Please enter the amount of the bill: 23.65
        Please enter the amount tendered: 100.00
        The change required is 76.35
        */
        static void Main(string[] args)
        {
            Console.Write("Please enter the amount of the bill: ");
            string input = Console.ReadLine();
            decimal amountOfBill = decimal.Parse(input);
            

            Console.Write("Please enter the amount tendered: ");
            input = Console.ReadLine();
            decimal amountTendered = decimal.Parse(input);

            decimal changeRequired = amountTendered - amountOfBill;

            Console.WriteLine("The change required is " + changeRequired.ToString("0.00"));

        }
    }
}
