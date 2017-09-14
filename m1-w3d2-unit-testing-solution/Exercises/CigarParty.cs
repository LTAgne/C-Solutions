using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class CigarParty
    {
        /*
         When squirrels get together for a party, they like to have cigars. A squirrel party is successful
         when the number of cigars is between 40 and 60, inclusive. Unless it is the weekend, in which case 
         there is no upper bound on the number of cigars. Return true if the party with the given values is 
         successful, or false otherwise.
         haveParty(30, false) → false
         haveParty(50, false) → true
         haveParty(70, true) → true
         */
        public bool HaveParty(int cigars, bool isWeekend)
        {
            const int MinimumCigarCount = 40;
            const int MaximumCigarCount = 60;

            bool hasMinimumCigars = (cigars >= MinimumCigarCount);
            bool withinMaxRangeOfCigars = (!isWeekend && cigars <= MaximumCigarCount) || isWeekend;
            bool successful = hasMinimumCigars && withinMaxRangeOfCigars;

            return successful;
        }

    }
}
