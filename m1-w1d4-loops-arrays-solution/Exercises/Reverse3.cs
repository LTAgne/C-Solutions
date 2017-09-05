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
         Given an array of ints length 3, return a new array with the elements in reverse order, so 
         {1, 2, 3} becomes {3, 2, 1}.
         reverse3([1, 2, 3]) → [3, 2, 1]
         reverse3([5, 11, 9]) → [9, 11, 5]
         reverse3([7, 0, 0]) → [0, 0, 7]
         */
        public int[] Reverse3(int[] nums)
        {
            int[] newArray = new int[nums.Length];

            // one for loop
            // i starts at the end of the nums array and decrements
            // j starts at 0 and increments
            for (int i = nums.Length - 1, j = 0; i >= 0; i--, j++)
            {
                newArray[j] = nums[i];
            }

            return newArray;
        }

    }
}
