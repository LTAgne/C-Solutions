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
         Return true if the given non-negative number is 1 or 2 more than a multiple of 20. 
         (Hint: Think "mod".)
         more20(20) → false
         more20(21) → true
         more20(22) → true
         */
        public bool More20(int n)
        {
            return (n % 20 == 1 || n % 20 == 2);
        }

    }
}
