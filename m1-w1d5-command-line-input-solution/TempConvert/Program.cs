using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConvert
{
    class Program
    {
        /*
         The Fahrenheit to Celsius conversion formula is:
 	        Tc = (Tf - 32) / 1.8
 	        where 'Tc' is the temperature in Celsius, and 'Tf' is the temperature in Fahrenheit
 	
         The Celsius to Fahrenheit conversion formula is:
 	        Tf = Tc * 1.8 + 32
 	
         Write a command line program which prompts a user to enter a temperature, and whether its in degrees (C)elsius or (F)arenheit.
         Convert the temperature to the opposite degrees, and display the old and new temperatures to the console.
  
         C:\Users> TempConvert
         Please enter the temperature: 58
         Is the temperature in (C)elcius, or (F)arenheit? F
         58F is 14C.
 
         Note why Tf - 32 above is enclosed in parentheses with a comment inside your code. You'll feel better for it, 
         and will start building some good programming habits while you're at it.
         */
        static void Main(string[] args)
        {
            
            Console.Write("Please enter the temperature: ");
            string tempInput = Console.ReadLine();
            int temp = int.Parse(tempInput);

            Console.Write("Is the temperature in (C)elcius, or (F)arenheit?: ");
            string scaleInput = Console.ReadLine();

            if ("F" == scaleInput)
            {
                int celciusTemp = (int)((temp - 32) / 1.8);
                Console.WriteLine(temp + "F is " + celciusTemp + "C.");
            }
            else if ("C" == scaleInput)
            {
                int fahrenheitTemp = (int)((temp * 1.8) + 32);
                Console.WriteLine(temp + "C is " + fahrenheitTemp + "F.");
            }
            else
            {
                Console.WriteLine(scaleInput + " is an invalid choice.");
            }


        }
    }
}
