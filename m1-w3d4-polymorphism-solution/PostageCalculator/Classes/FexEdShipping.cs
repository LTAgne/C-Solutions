using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class FexEdShipping : IDeliveryService
    {
        public string Name
        {
            get { return "FexEd"; }
        }

        public double CalculateRate(int weightInOunces, int distanceInMiles)
        {
            double flatRate = 20.00;

            if (distanceInMiles > 500)
            {
                flatRate = flatRate + 5.00;
            }
            if (weightInOunces > 48)
            {
                flatRate = flatRate + 3.00;
            }

            return flatRate;
        }
    }
}
