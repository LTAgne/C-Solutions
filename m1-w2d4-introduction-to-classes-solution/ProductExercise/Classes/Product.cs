using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Product
    {
        private string name;
        private decimal price;
        private double weightInOunces;   
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public double WeightInOunces
        {
            get { return this.weightInOunces; }
            set { this.weightInOunces = value; }
        }
    }
}
