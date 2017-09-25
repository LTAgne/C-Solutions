using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{

    public class KataFizzBuzz
    {

        public string fizzBuzz(int n)
        {
            if ((n < 1) || (n > 100)) return "";
            bool isDivisibleBy5 = n % 5 == 0;
            bool isDivisibleBy3 = n % 3 == 0;
            if (isDivisibleBy3 && isDivisibleBy5)
            {
                return "FizzBuzz";
            }
            if (isDivisibleBy5)
            {
                return "Buzz";
            }
            if (isDivisibleBy3)
            {
                return "Fizz";
            }
            // Step 2:
            // Add a final check to see if the number contains a 5 or 3 if it isn't divisible by 3 and/or 5
            String stringN = n.ToString();
            if (stringN.Contains("5"))
            {
                return "Buzz";
            }
            if (stringN.Contains("3"))
            {
                return "Fizz";
            }
            return stringN;
        }

    }
}
