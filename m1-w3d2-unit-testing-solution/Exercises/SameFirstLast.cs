using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class SameFirstLast
    {

        /*
         Given an array of ints, return true if the array is length 1 or more, and the first element and
         the last element are equal.
         IsItTheSame([1, 2, 3]) → false
         IsItTheSame([1, 2, 3, 1]) → true
         IsItTheSame([1, 2, 1]) → true
         */
        public bool IsItTheSame(int[] nums)
        {
            return (nums.Length > 0 && nums[0] == nums[nums.Length - 1]);
        }

    }
}
