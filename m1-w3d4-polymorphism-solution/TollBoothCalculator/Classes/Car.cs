using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{
    public class Car : IVehicle
    {
        private bool hasTrailer;

        public Car(bool hasTrailer)
        {
            this.hasTrailer = hasTrailer;
        }
        
        public bool HasTrailer
        {
            get { return hasTrailer; }
        }

        public string Type
        {
            get { return "Car"; }
        } 

        public double CalculateToll(int distance)
        {
            double toll = (distance * 0.020);
            if (hasTrailer)
            {
                toll += 1.0;
            }
            return toll;
        }
    }
}