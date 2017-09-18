using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.Classes
{
    public class Stereo : AutoPart
    {
        private bool hasAuxilaryInput;
        public bool HasAuxilaryInput
        {
            get { return hasAuxilaryInput; }
            set { hasAuxilaryInput = value; }
        }

        private double heightInInches;
        public double HeightInInches
        {
            get { return heightInInches; }
            set { heightInInches = value; }
        }

        private int numberOfStationPresets;
        public int NumberOfStationPresets
        {
            get { return numberOfStationPresets; }
            set { numberOfStationPresets = value; }
        }


    }
}
