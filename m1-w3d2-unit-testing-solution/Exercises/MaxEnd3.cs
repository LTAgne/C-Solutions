using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class MaxEnd3
    {
        /*
         Given an array of ints length 3, figure out which is larger between the first and last elements 
         in the array, and set all the other elements to be that value. Return the changed array.
         MakeArray([1, 2, 3]) → [3, 3, 3]
         MakeArray([11, 5, 9]) → [11, 11, 11]
         MakeArray([2, 11, 3]) → [3, 3, 3]
         */
        public int[] MakeArray(int[] nums)
        {
            int largerNum = (nums[0] > nums[nums.Length - 1]) ? nums[0] : nums[nums.Length - 1];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = largerNum;
            }

            return nums;
        }

    }
}
