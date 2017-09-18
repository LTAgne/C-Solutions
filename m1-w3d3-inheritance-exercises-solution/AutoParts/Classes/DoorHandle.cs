using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.Classes
{
    public class DoorHandle : AutoPart
    {
        private bool isTouchlessHandle;

        public bool IsTouchlessHandle
        {
            get { return isTouchlessHandle; }
            set { isTouchlessHandle = value; }
        }

        private string materialType;

        public string MaterialType
        {
            get { return materialType; }
            set { materialType = value; }
        }

    }
}
