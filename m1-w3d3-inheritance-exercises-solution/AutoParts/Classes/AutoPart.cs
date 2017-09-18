using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.Classes
{
    public class AutoPart
    {
        private string manufacturer;
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        private string partNumber;
        public string PartNumber
        {
            get { return partNumber; }
            set { partNumber = value; }
        }

        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}
