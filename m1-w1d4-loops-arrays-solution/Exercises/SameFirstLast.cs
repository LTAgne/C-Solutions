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
         Given an array of ints, return true if the array is length 1 or more, and the first element and
         the last element are equal.
         sameFirstLast([1, 2, 3]) → false
         sameFirstLast([1, 2, 3, 1]) → true
         sameFirstLast([1, 2, 1]) → true
         */
        public bool SameFirstLast(int[] nums)
        {
            return (nums.Length > 0 && nums[0] == nums[nums.Length - 1]);
        }

    }
}
