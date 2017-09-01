using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
      Given 2 positive int values, return the larger value that is in the range 10..20 inclusive, 
      or return 0 if neither is in that range.
      max1020(11, 19) → 19
      max1020(19, 11) → 19
      max1020(11, 9) → 11
      */
        public int Max1020(int a, int b)
        {
            // First make it so the bigger value is in a
            if (b > a)
            {
                // Usuallly, swapping is implemented using a third variable like "swap".
                int temp = a;
                a = b;
                b = temp;
                // There is an alternative technique that doesn't involve a third variable.
                // This has been known to occasionally come up in technical interviews.
                // Additionally, it's just fun to know.
                // Note, this alternative only works with ints and longs
                // a = a + b;
                // b = a - b;
                // a = a - b;
            }

            // Knowing a is bigger, just check a first
            if (a >= 10 && a <= 20) return a;
            if (b >= 10 && b <= 20) return b;
            return 0;
        }

    }
}
