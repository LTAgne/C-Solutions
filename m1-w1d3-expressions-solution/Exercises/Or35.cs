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
        Return true if the given non-negative number is a multiple of 3 or a multiple of 5. 
        (Hint: Think "mod".)
        or35(3) → true
        or35(10) → true
        or35(8) → false
        */
        public bool Or35(int n)
        {
            return (n % 3 == 0) || (n % 5 == 0);
        }

    }
}
