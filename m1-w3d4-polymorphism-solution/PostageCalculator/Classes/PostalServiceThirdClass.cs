using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class PostalServiceThirdClass : IDeliveryService
    {
        const int ThreePoundsInOz = 48;
        const int EightPoundsInOz = 128;

        public string Name
        {
            get { return "Postal Service (3rd Class)"; }
        }

        public double CalculateRate(int weightInOunces, int distanceInMiles)
        {
            double rate = 0.0;

            if (weightInOunces <= 2) rate = 0.0020;
            else if (weightInOunces <= 8) rate = 0.0022;
            else if (weightInOunces <= 15) rate = 0.0024;
            else if (weightInOunces <= ThreePoundsInOz) rate = 0.0150;
            else if (weightInOunces <= EightPoundsInOz) rate = 0.0160;
            else rate = 0.0170;

            return rate * distanceInMiles;
        }
    }
}
