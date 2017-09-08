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
          Given an array of Integers, return a List of Integers containing just the odd values.
          oddOnly( {112, 201, 774, 92, 9, 83, 41872} ) -> [201, 9, 83]
          oddOnly( {1143, 555, 7, 1772, 9953, 643} ) -> [1143, 555, 7, 9953, 643]
          oddOnly( {734, 233, 782, 811, 3, 9999} ) -> [233, 811, 3, 9999]  
          */
        public List<int> OddOnly(int[] integerArray)
        {
            List<int> output = new List<int>();

            foreach (int number in integerArray)
            {
                if (number % 2 == 1)
                {
                    output.Add(number);
                }
            }

            return output;
        }
    }
}
