using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercises.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public List<string> PreparationSteps { get; set; } = new List<string>();
        public double AverageRating { get; set; }
        public int CookTimeInMinutes { get; set; }
        public string RecipeType { get; set; }

    }
}