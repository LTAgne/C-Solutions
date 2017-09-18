using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.Classes
{
    public class Seat : AutoPart
    {
        private bool includesHeater;
        public bool IncludesHeater
        {
            get { return includesHeater; }
            set { includesHeater = value; }
        }

        private string materialType;
        public string MaterialType
        {
            get { return materialType; }
            set { materialType = value; }
        }

    }
}
