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
         Given three ints, a b c, return true if they are in strict increasing order, such as 2 5 11, 
         or 5 6 7, but not 6 5 7 or 5 5 7. However, with the exception that if "equalOk" is true, equality 
         is allowed, such as 5 5 7 or 5 5 5.
         inOrderEqual(2, 5, 11, false) → true
         inOrderEqual(5, 7, 6, false) → false
         inOrderEqual(5, 5, 7, true) → true
         */
        public bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            if (equalOk)
            {
                return a <= b && b <= c;
            }
            else
            {
                return a < b && b < c;
            }
        }

    }
}
