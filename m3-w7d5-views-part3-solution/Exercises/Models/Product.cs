using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercises.Models
{
    public class Product
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string ImageName { get; set; }
        public double WeightIbLbs { get; set; }
        public double Price { get; set; }
        public double AverageRating { get; set; }
        public int RemainingStock { get; set; }
        public bool IsTopSeller { get; set; }
        public string Description { get; set; }
    }
}