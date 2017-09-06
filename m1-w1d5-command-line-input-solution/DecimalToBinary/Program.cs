using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        /*
        Write a command line program which accepts a series of decimal integer values as command line arguments, 
        and displays each decimal value as itself and its binary equivalent

        C:\Users> DecimalToBinary
    
        Please enter in a series of decimal values (separated by spaces): 460 8218 1 31313 987654321
    
        460 in binary is 111001100
        8218 in binary is 10000000011010
        1 in binary is 1
        31313 in binary is 111101001010001
        987654321 in binary is 111010110111100110100010110001
        */

        static void Main(string[] args)
        {
            Console.Write("Please enter in a series of decimal values (separated by spaces): ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            for (int i = 0; i < numbers.Length; i++)
            {
                string binary = "";

                int base10 = int.Parse(numbers[i]);
                while (base10 > 0)
                {
                    binary = (base10 % 2) + binary;
                    base10 = base10 / 2;
                }                
                
                Console.WriteLine(numbers[i] + " in binary is " + binary);
            }
        }
    }
}
