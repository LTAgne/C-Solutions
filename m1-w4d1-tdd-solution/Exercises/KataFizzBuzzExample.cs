using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class KataFizzBuzzExample
    {
        static void Main(string[] args)
        {
            KataFizzBuzz kfb = new KataFizzBuzz();
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(kfb.fizzBuzz(i));
            }
        }
    }
}
