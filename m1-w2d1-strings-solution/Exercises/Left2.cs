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
         Given a string, return a "rotated left 2" version where the first 2 chars are moved to the end. 
         The string length will be at least 2.
         left2("Hello") → "lloHe"	
         left2("java") → "vaja"	
         left2("Hi") → "Hi"	
         */
        public string Left2(string str)
        {
            return str.Substring(2) + str.Substring(0, 2);
        }
    }
}
