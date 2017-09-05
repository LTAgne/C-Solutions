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
         Given an array of ints, return true if 6 appears as either the first or last element in the array. 
         The array will be length 1 or more.
         firstLast6([1, 2, 6]) → true
         firstLast6([6, 1, 2, 3]) → true
         firstLast6([13, 6, 1, 2, 3]) → false
         */
        public bool FirstLast6(int[] nums)
        {
            return (nums[0] == 6 || nums[nums.Length - 1] == 6);
        }
    }
}
