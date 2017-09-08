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
               Given a List of string, return a new list in reverse order of the original. One obvious solution is to
               simply loop through the original list in reverse order, but see if you can come up with an alternative
               solution. (Hint: Think LIFO (i.e. stack))
               reverseList( ["purple", "green", "blue", "yellow", "green" ])  -> ["green", "yellow", "blue", "green", "purple" ]
               reverseList( ["jingle", "bells", "jingle", "bells", "jingle", "all", "the", "way"} )
                  -> ["way", "the", "all", "jingle", "bells", "jingle", "bells", "jingle"]
               */
        public List<string> ReverseList(List<string> objectList)
        {
            // One solution
            //objectList.Reverse();
            //return objectList;

            // 2nd Solution
            //Stack<string> words = new Stack<string>(objectList);
            //return words.ToList();

            // 3rd Solution
            Stack<string> words = new Stack<string>();

            foreach (string word in objectList)
            {
                words.Push(word);
            }
            return words.ToList();
        }

    }
}
