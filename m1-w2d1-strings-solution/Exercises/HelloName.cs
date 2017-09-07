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
         Given a string name, e.g. "Bob", return a greeting of the form "Hello Bob!".
         helloName("Bob") → "Hello Bob!"
         helloName("Alice") → "Hello Alice!"
         helloName("X") → "Hello X!"
         */
        public string HelloName(string name)
        {
            return "Hello " + name + "!";
        }

    }
}
