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
         Given a string, return true if "bad" appears starting at index 0 or 1 in the string, such as with 
         "badxxx" or "xbadxx" but not "xxbadxx". The string may be any length, including 0. Note: use .equals()
         to compare 2 strings.
         hasBad("badxx") → true	
         hasBad("xbadxx") → true	
         hasBad("xxbadxx") → false	
         */
        public bool HasBad(string str)
        {
            if (str.Length <= 2)
            {
                return false;
            }
            else if (str.Length == 3)
            {
                return str.Substring(0, 3) == ("bad");
            }
            else
            {
                return str.Substring(0, 3) == ("bad") || str.Substring(1, 3) == ("bad");
            }
        }
    }
}
