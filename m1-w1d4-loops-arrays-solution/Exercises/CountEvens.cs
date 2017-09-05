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
         Return the number of even ints in the given array. Note: the % "mod" operator computes the 
         remainder, e.g. 5 % 2 is 1.
         countEvens([2, 1, 2, 3, 4]) → 3
         countEvens([2, 2, 0]) → 3
         countEvens([1, 3, 5]) → 0
         */
        public int CountEvens(int[] nums)
        {
            int eventIntCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    eventIntCount++;
                }
            }

            return eventIntCount;
        }

    }
}
