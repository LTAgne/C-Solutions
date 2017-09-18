using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.Classes
{
    public class WindshieldWiper : AutoPart
    {
        private double length;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        private bool isDriverSide;

        public bool IsDriverSide
        {
            get { return isDriverSide; }
            set { isDriverSide = value; }
        }

    }
}
