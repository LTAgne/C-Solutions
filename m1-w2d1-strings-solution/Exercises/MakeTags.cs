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
        The web is built with HTML strings like "<i>Yay</i>" which draws Yay as italic text. In this example,
        the "i" tag makes <i> and </i> which surround the word "Yay". Given tag and word strings, create the 
        HTML string with tags around the word, e.g. "<i>Yay</i>".
        makeTags("i", "Yay") → "<i>Yay</i>"
        makeTags("i", "Hello") → "<i>Hello</i>"
        makeTags("cite", "Yay") → "<cite>Yay</cite>"
        */
        public string MakeTags(string tag, string word)
        {
            return "<" + tag + ">" + word + "</" + tag + ">";
        }
    }
}
