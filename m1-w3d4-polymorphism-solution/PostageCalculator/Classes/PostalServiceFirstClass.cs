using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class PostalServiceFirstClass : IDeliveryService
    {        
        const int ThreePoundsInOz = 48;
        const int EightPoundsInOz = 128;

        public string Name
        {
            get { return "Postal Service (1st Class)"; }
        }

        public double CalculateRate(int weightInOunces, int distanceInMiles)
        {
            double rate = 0.0;

            if (weightInOunces <= 2) rate = 0.035;
            else if (weightInOunces <= 8) rate = 0.040;
            else if (weightInOunces <= 15) rate = 0.047;
            else if (weightInOunces <= ThreePoundsInOz) rate = 0.195;
            else if (weightInOunces <= EightPoundsInOz) rate = 0.450;
            else rate = 0.500;

            return rate * distanceInMiles;            
        }
    }
}
