using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public interface IDeliveryService
    {
        string Name { get; }
        double CalculateRate(int weightInOunces, int distanceInMiles);
    }
}
