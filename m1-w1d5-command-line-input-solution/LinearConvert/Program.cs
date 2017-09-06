using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearConvert
{
    class Program
    {
        /*
         The foot to meter conversion formula is:
 	        m = f * 0.3048
 	
         The meter to foot conversion formula is:
 	        f = m * 3.2808399
 	
         Write a command line program which prompts a user to enter a length, and whether the measurement is in (m)eters or (f)eet.
         Convert the length to the opposite measurement, and display the old and new measurements to the console.
  
         C:\Users> LinearConvert
         Please enter the length: 58
         Is the measurement in (m)eter, or (f)eet? f
         58f is 17m.
         */

        static void Main(string[] args)
        {
            

            Console.Write("Please enter the length: ");
            string lengthInput = Console.ReadLine();
            int length = int.Parse(lengthInput);

            Console.Write("Is the measurement in (m)eters, or (f)eet?: ");
            string unitInput = Console.ReadLine();

            if ("f" == unitInput)
            {
                int meterLength = (int)(length * .3048);
                Console.WriteLine(length + "f is " + meterLength + "m.");
            }
            else if ("m" == unitInput)
            {
                int feetLength = (int)(length * 3.2808399);
                Console.WriteLine(length + "m is " + feetLength + "f.");
            }
            else
            {
                Console.WriteLine(unitInput + " is an invalid choice.");
            }
        }
    }
}
