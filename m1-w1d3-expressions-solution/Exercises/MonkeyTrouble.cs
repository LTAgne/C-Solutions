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
         We have two monkeys, a and b, and the parameters aSmile and bSmile indicate if each is smiling. 
         We are in trouble if they are both smiling or if neither of them is smiling. Return true if we 
         are in trouble.
         monkeyTrouble(true, true) → true
         monkeyTrouble(false, false) → true
         monkeyTrouble(true, false) → false
         */
        public bool MonkeyTrouble(bool aSmile, bool bSmile)
        {
            bool areWeInTrouble = (aSmile && bSmile) || (!aSmile && !bSmile);
            //bool areWeInTrouble = !(aSmile ^ bSmile); <-- Another alternative

            return areWeInTrouble;
        }

    }
}
