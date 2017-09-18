using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class PostalServiceSecondClass : IDeliveryService
    {
        const int ThreePoundsInOz = 48;
        const int EightPoundsInOz = 128;

        public string Name
        {
            get { return "Postal Service (2nd Class)"; }
        }

        public double CalculateRate(int weightInOunces, int distanceInMiles)
        {
            double rate = 0.0;

            if (weightInOunces <= 2) rate = 0.0035;
            else if (weightInOunces <= 8) rate = 0.0040;
            else if (weightInOunces <= 15) rate = 0.0047;
            else if (weightInOunces <= ThreePoundsInOz) rate = 0.0195;
            else if (weightInOunces <= EightPoundsInOz) rate = 0.0450;
            else rate = 0.0500;

            return rate * distanceInMiles;
        }
    }
}
