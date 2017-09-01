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
         Given three ints, a b c, return true if it is possible to add two of the ints to get the third.
         twoAsOne(1, 2, 3) → true
         twoAsOne(3, 1, 2) → true
         twoAsOne(3, 2, 2) → false
         */
        public bool TwoAsOne(int a, int b, int c)
        {
            return a + b == c || b + c == a || a + c == b;
        }

    }
}
