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
        The squirrels in Palo Alto spend most of the day playing. In particular, they play if the temperature
        is between 60 and 90 (inclusive). Unless it is summer, then the upper limit is 100 instead of 90. Given 
        an int temperature and a bool isSummer, return true if the squirrels play and false otherwise.
        squirrelPlay(70, false) → true
        squirrelPlay(95, false) → false
        squirrelPlay(95, true) → true
        */
        public bool SquirrelPlay(int temp, bool isSummer)
        {
            int upperTempRange = (isSummer) ? 100 : 90;
            int lowerTempRange = 60;

            bool tempInRange = (lowerTempRange <= temp && temp <= upperTempRange);

            return tempInRange;
        }

    }
}
