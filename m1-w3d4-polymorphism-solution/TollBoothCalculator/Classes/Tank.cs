using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{
    public class Tank : IVehicle
    {
        public string Type
        {
            get { return "Tank"; }
        }

        public double CalculateToll(int Distance)
        {
            return 0;
        }
    }
}
