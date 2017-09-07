using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string and an index, return a string length 2 starting at the given index. If the index is 
         too big or too small to define a string length 2, use the first 2 chars. The string length will be 
         at least 2.
         twoChar("java", 0) → "ja"	
         twoChar("java", 2) → "va"	
         twoChar("java", 3) → "ja"	
         */
        public string TwoChar(string str, int index)
        {
            if (index < 0 || index + 2 > str.Length)
            {
                return str.Substring(0, 2);
            }
            return str.Substring(index, 2);
        }
    }
}
