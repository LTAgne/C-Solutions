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
         Given 2 strings, a and b, return a string of the form short+long+short, with the shorter string 
         on the outside and the longer string on the inside. The strings will not be the same length, but 
         they may be empty (length 0).
         combostring("Hello", "hi") → "hiHellohi"	
         combostring("hi", "Hello") → "hiHellohi"	
         combostring("aaa", "b") → "baaab"	
         */
        public string ComboString(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return b + a + b;
            }
            else
            {
                return a + b + a;
            }
        }
    }
}
