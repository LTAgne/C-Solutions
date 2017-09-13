using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /**
    * This class represents a dog that can sleep, wake, and make a sound, so it's pretty much like most dogs,
    * with a few essential methods missing.
    */
    public class Dog
    {
        
        private bool isSleeping;
        public bool IsSleeping
        {
            get { return this.isSleeping; }
        }

        public Dog()
        {
            this.isSleeping = false;
        }        
        
        public string MakeSound()
        {
            if (this.isSleeping)
            {
                return "Zzzzz...";
            }
            else
            {
                return "woof!";
            }
        }

        
        public void Sleep()
        {
            this.isSleeping = true;
        }

        
        public void WakeUp()
        {
            this.isSleeping = false;
        }


    }
}
