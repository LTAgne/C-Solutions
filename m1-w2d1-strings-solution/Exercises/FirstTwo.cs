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
         Given a string, return the string made of its first two chars, so the string "Hello" yields "He". If the 
         string is shorter than length 2, return whatever there is, so "X" yields "X", and the empty string "" 
         yields the empty string "". Note that str.Length returns the length of a string.
         firstTwo("Hello") → "He"	
         firstTwo("abcdefg") → "ab"	
         firstTwo("ab") → "ab"	
         */
        public string FirstTwo(string str)
        {
            if (str.Length < 2)
            {
                return str;
            }
            else
            {
                return str.Substring(0, 2);
            }
        }
    }
}
