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
         Given a List of integers, return the largest value.
         findLargest( [11, 200, 43, 84, 9917, 4321, 1, 33333, 8997] ) -> 33333
         findLargest( [987, 1234, 9381, 731, 43718, 8932] ) -> 43718
         findLargest( [34070, 1380, 81238, 7782, 234, 64362, 627] ) -> 64362
         */
        public int FindLargest(List<int> integerList)
        {
            // 1 Solution
            //return integerList.Max();

            // 2 Solution
            int maxValue = 0;

            foreach (int number in integerList)
            {
                if (number > maxValue)
                {
                    maxValue = number;
                }
            }

            return maxValue;
        }

    }
}
