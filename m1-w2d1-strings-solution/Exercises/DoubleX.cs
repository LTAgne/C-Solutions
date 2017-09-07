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
         Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
         doubleX("axxbb") → true
         doubleX("axaxax") → false	
         doubleX("xxxxx") → true	
         */
        public bool DoubleX(string str)
        {
            int firstX = str.IndexOf('x');
            if (firstX < str.Length - 1)
            {
                return str[firstX + 1] == 'x';
            }
            return false;
        }
    }
}
