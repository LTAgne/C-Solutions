using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.Classes
{
    public class Headlight : AutoPart
    {
        private int lumens;
        public int Lumens
        {
            get { return lumens; }
            set { lumens = value; }
        }

        private int lifeHours;
        public int LifeHours
        {
            get { return lifeHours; }
            set { lifeHours = value; }
        }
        
    }
}
