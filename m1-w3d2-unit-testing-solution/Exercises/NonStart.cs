using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class NonStart
    {
        /*
         Given 2 strings, return their concatenation, except omit the first char of each. The strings will 
         be at least length 1.
         GetPartialString("Hello", "There") → "ellohere"
         GetPartialString("java", "code") → "avaode"	
         GetPartialString("shotl", "java") → "hotlava"	
         */
        public string GetPartialString(string a, string b)
        {
            if (a.Length == 0)
            {
                return b.Substring(1);
            }
            else if (b.Length == 0)
            {
                return a.Substring(1);
            }
            else
            {
                return a.Substring(1) + b.Substring(1);
            }
        }
    }
}
