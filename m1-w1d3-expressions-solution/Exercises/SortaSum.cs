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
         Given 2 ints, a and b, return their sum. However, sums in the range 10..19 inclusive, are forbidden, 
         so in that case just return 20.
         sortaSum(3, 4) → 7
         sortaSum(9, 4) → 20
         sortaSum(10, 11) → 21
         */
        public int SortaSum(int a, int b)
        {
            int sum = a + b;

            if (sum >= 10 && sum <= 19)
            {
                return 20;
            }

            return sum;
        }

    }
}
