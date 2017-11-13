using Exercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercises.Controllers
{
    public class RecipeController : Controller
    {
        // GET: Recipe
        public ActionResult Tile()
        {
            return View("Tile", GetRecipes());
        }

        public ActionResult Board()
        {
            return View("Board", GetRecipes());
        }

        public ActionResult Table()
        {
            return View("Table", GetRecipes());
        }

        public ActionResult Detail(string id)
        {
            var recipe = GetRecipes()[id.ToLower()];
            return View("Detail", recipe);
        }


        // HELPER METHOD
        private Dictionary<string, Recipe> GetRecipes()
        {
            Recipe chiliGarlic = new Recipe()
            {
                Id = "roasted-chili-broccoli",
                Name = "Chili Garlic Roasted Broccoli",
                Description = "A tasty vegetable side that comes together in minutes and cooks without fuss? Yes, please. Allow the broccoli to roast until the florets are well browned and a bit crispy, and you’ll be hooked.",
                AverageRating = 3.2,
                CookTimeInMinutes = 20
            };
            chiliGarlic.RecipeType = "Vegetarian";
            chiliGarlic.PreparationSteps.Add("Preheat oven to 425° F.");
            chiliGarlic.PreparationSteps.Add("Combine olive oil, lime juice, garlic, and chili powder in bottom of large bowl. Add broccoli and mix until spears are coated. Season with salt and pepper, if desired. Arrange on baking sheet, and roast 17 to 20 minutes, until florets are brown and crispy at the edges.");
            chiliGarlic.Ingredients.Add(new Ingredient() { Quantity = "2 Tbs.", Name = "olive oil" });
            chiliGarlic.Ingredients.Add(new Ingredient() { Quantity = "2 Tbs.", Name = "lime juice" });
            chiliGarlic.Ingredients.Add(new Ingredient() { Quantity = "4 Cloves", Name = "garlic, minced" });
            chiliGarlic.Ingredients.Add(new Ingredient() { Quantity = "1 Tbs.", Name = "chili powder" });
            chiliGarlic.Ingredients.Add(new Ingredient() { Quantity = "2 medium heads", Name = "broccoli, cut into long spears" });


            Recipe mexicanRicePilaf = new Recipe()
            {
                Id = "mexican-rice-pilaf",
                Name = "Mexican Green Rice Pilaf",
                Description = "This bright side dish goes especially well with enchiladas or tacos. Unsweetened almond milk lends a natural, delicate sweetness and moistness to the rice while also boosting protein content.",
                AverageRating = 4.2,
                CookTimeInMinutes = 35
            };
            mexicanRicePilaf.RecipeType = "Vegetarian";
            mexicanRicePilaf.PreparationSteps.Add("Purée broth, almond milk, watercress sprigs, cilantro, and salt in blender until smooth.");
            mexicanRicePilaf.PreparationSteps.Add("Heat oil in medium saucepan over medium-high heat. Add rice, and sauté 2 minutes. Add onion and garlic. Stir in watercress purée, and bring to simmer, stirring often. Reduce heat to low. Cover tightly, and simmer 15 minutes, or until rice is almost tender. Remove from heat. Let stand, covered, 3 minutes");
            mexicanRicePilaf.PreparationSteps.Add("Gently fluff rice with fork. Transfer to bowl, and serve sprinkled with watercress leaves and pumpkin seeds, if using.");
            mexicanRicePilaf.Ingredients.Add(new Ingredient() { Quantity = "1½ cups", Name = "low-sodium vegetable broth" });
            mexicanRicePilaf.Ingredients.Add(new Ingredient() { Quantity = "1 cup", Name = "plain unsweetened almond milk" });
            mexicanRicePilaf.Ingredients.Add(new Ingredient() { Quantity = "1 cup", Name = "packed, trimmed watercress sprigs, plus more watercress for garnish, divided" });
            mexicanRicePilaf.Ingredients.Add(new Ingredient() { Quantity = "½ cup", Name = "packed cilantro leaves" });
            mexicanRicePilaf.Ingredients.Add(new Ingredient() { Quantity = "½ tsp.", Name = "salt" });
            mexicanRicePilaf.Ingredients.Add(new Ingredient() { Quantity = "1 ½ Tbs.", Name = "olive oil" });
            mexicanRicePilaf.Ingredients.Add(new Ingredient() { Quantity = "1 ½ cups", Name = "jasmine rice" });
            mexicanRicePilaf.Ingredients.Add(new Ingredient() { Quantity = "1 small", Name = "onion, finely chopped (¾ cup)" });
            mexicanRicePilaf.Ingredients.Add(new Ingredient() { Quantity = "2 cloves", Name = "garlic, minced" });
            mexicanRicePilaf.Ingredients.Add(new Ingredient() { Quantity = "6 Tbs.", Name = "toasted, salted pepitas or pumpkin seeds, optional" });


            Recipe pasta = new Recipe()
            {
                Id = "arugula-pasta",
                Name = "Pasta with Blue Cheese, Arugula, Figs, and Walnuts",
                Description = "Lightly wilted arugula lends a fresh, green, peppery flavor to this quick pasta recipe. The dish is a great way to use up bunches of arugula that are slightly wilted or just past their prime.",
                AverageRating = 2.3,
                CookTimeInMinutes = 35
            };
            pasta.RecipeType = "Vegetarian";
            pasta.PreparationSteps.Add("Whisk together shallots, vinegar, vegetable oil, ginger, and sesame oil in small bowl. Season with salt and pepper, if desired.");
            pasta.PreparationSteps.Add("Toss together watercress and mushrooms in large bowl with half of dressing. Spread salad out on medium platter. Tuck tangerine slices and avocado wedges in between watercress sprigs. Drizzle remaining dressing over salad.");
            pasta.Ingredients.Add(new Ingredient() { Quantity = "½ lb.", Name = "curly pasta, such as cavatappi" });
            pasta.Ingredients.Add(new Ingredient() { Quantity = "½ cup", Name = "low-fat cottage cheese" });
            pasta.Ingredients.Add(new Ingredient() { Quantity = "2 oz.", Name = "strong blue cheese, such as Point Reyes or Danish Blue, plus more for garnish (optional)" });
            pasta.Ingredients.Add(new Ingredient() { Quantity = "3 cups", Name = "arugula, divided" });
            pasta.Ingredients.Add(new Ingredient() { Quantity = "6", Name = "dried figs, chopped (⅓ cup)" });
            pasta.Ingredients.Add(new Ingredient() { Quantity = "⅓ cup", Name = "chopped toasted walnuts or pistachios" });
            pasta.Ingredients.Add(new Ingredient() { Quantity = "¼ tsp.", Name = "coarsely ground black pepper" });


            Dictionary<string, Recipe> recipes = new Dictionary<string, Recipe>()
            {
                {"roasted-chili-broccoli", chiliGarlic },
                {"mexican-rice-pilaf", mexicanRicePilaf },
                {"arugula-pasta", pasta }
            };

            return recipes;

        }
    }
}