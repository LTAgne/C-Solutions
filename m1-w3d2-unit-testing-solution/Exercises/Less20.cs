using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Less20
    {
        /*
         Return true if the given non-negative number is 1 or 2 less than a multiple of 20. So for example 38 
         and 39 return true, but 40 returns false. 
         (Hint: Think "mod".)
         less20(18) → true
         less20(19) → true
         less20(20) → false
         */
        public bool IsLessThanMultipleOf20(int n)
        {
            bool oneLessThanMultipleOf20 = (n % 20 == 19);
            bool twoLessThanMultipleOf20 = (n % 20 == 18);

            return oneLessThanMultipleOf20 || twoLessThanMultipleOf20;
        }

    }
}
