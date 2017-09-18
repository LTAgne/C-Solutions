using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.Classes
{
    public class Tire : AutoPart
    {
        private int speedRating;
        public int SpeedRating
        {
            get { return speedRating; }
            set { speedRating = value; }
        }

        private int recommendedPsi;
        public int RecommendedPsi
        {
            get { return recommendedPsi; }
            set { recommendedPsi = value; }
        }

        private bool handlesSnowWell;
        public bool HandlesSnowWell
        {
            get { return handlesSnowWell; }
            set { handlesSnowWell = value; }
        }


    }
}
