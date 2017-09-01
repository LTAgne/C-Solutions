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
         We'll say a number is special if it is a multiple of 11 or if it is one more than a multiple of 11. 
         Return true if the given non-negative number is special. 
         (Hint: Think "mod".)
         specialEleven(22) → true
         specialEleven(23) → true
         specialEleven(24) → false
         */
        public bool SpecialEleven(int n)
        {
            if (n % 11 == 0 || n % 11 == 1)
            {
                return true;
            }

            return false;
        }

    }
}
