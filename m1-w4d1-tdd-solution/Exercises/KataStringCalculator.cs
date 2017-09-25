using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataStringCalculator
    {
        public int Add(string numbersToAdd)
        {
            int sum = 0;
            if (numbersToAdd.Length != 0)
            {
                string delimiter = ",";
                if (numbersToAdd.StartsWith("//"))
                {
                    int terminator = numbersToAdd.IndexOf("\n");
                    delimiter = numbersToAdd.Substring(2, terminator-2);
                    numbersToAdd = numbersToAdd.Substring(terminator+1);
                }
                numbersToAdd = numbersToAdd.Replace("\n", delimiter);
                string[] numberStrings = numbersToAdd.Split(Char.Parse(delimiter));
                foreach (string number in numberStrings)
                {
                    sum += Int32.Parse(number);
                }
            }
            return sum;
        }
    }
}
