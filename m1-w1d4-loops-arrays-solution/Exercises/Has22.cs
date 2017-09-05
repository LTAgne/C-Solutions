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
         Given an array of ints, return true if the array contains a 2 next to a 2 somewhere.
         has22([1, 2, 2]) → true
         has22([1, 2, 1, 2]) → false
         has22([2, 1, 2]) → false
         */
        public bool Has22(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == 2 && nums[i - 1] == 2)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
