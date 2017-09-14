using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class WordCount
    {
        /*
         * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the 
         * number of times that string appears in the array.
         * 
         * ** A CLASSIC **
         * 
         * GetCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
         * GetCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
         * GetCount([]) → {}
         * GetCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
         * 
         */
        public Dictionary<string, int> GetCount(string[] words)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!output.ContainsKey(word))
                {
                    output[word] = 1;
                }
                else
                {
                    output[word] = output[word] + 1;
                }
            }

            return output;
        }
    }
}
