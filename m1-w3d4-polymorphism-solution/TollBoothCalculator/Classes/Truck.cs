using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{
    public class Truck : IVehicle
    {
        private int numberOfAxles;

        public Truck(int numberOfAxles)
        {
            this.numberOfAxles = numberOfAxles;
        }

        public int NumberOfAxles
        {
            get { return numberOfAxles; }
        }

        public string Type
        {
            get { return "Truck"; }
        }

        public double CalculateToll(int distance)
        {
            if (numberOfAxles >= 8)
            {
                return distance * 0.048;
            }
            else if (numberOfAxles >= 6)
            {
                return distance * 0.045;
            }
            else 
            {
                return distance * 0.040;
            }
        }
    }
}
