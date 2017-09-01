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
       Given 2 int values, return true if one is negative and one is positive. Except if the parameter 
       "negative" is true, then return true only if both are negative.
       posNeg(1, -1, false) → true
       posNeg(-1, 1, false) → true
       posNeg(-4, -5, true) → true
       */
        public bool PosNeg(int a, int b, bool negative)
        {
            if (negative)
            {
                return (a < 0 && b < 0); // both negative
            }
            else
            {
                return (a < 0) ^ (b < 0); //one positive one negative
            }
        }

    }
}
