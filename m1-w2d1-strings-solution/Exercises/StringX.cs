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
         Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end 
         should not be removed.
         stringX("xxHxix") → "xHix"
         stringX("abxxxcd") → "abcd"
         stringX("xabxxxcdx") → "xabcdx"
         */
        public string StringX(string str)
        {
            string result = "";
            if (str.Length <= 2) return str;
            result += str[0];
            for (int i = 1; i < str.Length - 1; i++)
            {
                if (str[i] != 'x') result += str[i];
            }
            result += str[str.Length - 1];
            return result;
        }
    }
}
