using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataPrimeFactors
    {
        public int[] Factorize(int number)
        {
            List<int> primeFactors = new List<int>();
            if (number > 1)
            {
                int i = 2;
                while (i <= number)
                {
                    if (number % i == 0)
                    {
                        primeFactors.Add(i);
                        number /= i;
                        i = 2;
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            return primeFactors.ToArray();
        }

    }
}
