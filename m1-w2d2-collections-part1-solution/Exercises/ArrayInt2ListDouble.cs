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
             Given an array of ints, divide each int by 2, and return a List of Doubles.
             arrayInt2ListDouble( {5, 8, 11, 200, 97} ) -> [2.5, 4.0, 5.5, 100, 48.5]
             arrayInt2ListDouble( {745, 23, 44, 9017, 6} ) -> [372.5, 11.5, 22, 4508.5, 3]
             arrayInt2ListDouble( {84, 99, 3285, 13, 877} ) -> [42, 49.5, 1642.5, 6.5, 438.5]
             */
        public List<double> ArrayInt2ListDouble(int[] intArray)
        {
            List<double> output = new List<double>();

            foreach (int number in intArray)
            {
                double d = (double)number / 2;
                output.Add(d);
            }

            return output;
        }


    }
}
