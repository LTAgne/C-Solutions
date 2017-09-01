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
         Given two int values, return their sum. Unless the two values are the same, then return double their sum.
         sumDouble(1, 2) → 3
         sumDouble(3, 2) → 5
         sumDouble(2, 2) → 8
         */
        public int SumDouble(int a, int b)
        {
            if (a == b)
            {
                return 2 * (a + b);
            }
            else
            {
                return a + b;
            }
        }
    }
}
