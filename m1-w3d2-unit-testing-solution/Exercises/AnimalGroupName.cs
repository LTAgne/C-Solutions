using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class AnimalGroupName
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").  
         * 
         * The animal name should be case insensitive so "elephant", "Elephant", and 
         * "ELEPHANT" should all return "herd". 
         * 
         * If the name of the animal is not found, null, or empty, return "unknown". 
         * 
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * GetHerd("giraffe") → "Tower"
         * GetHerd("") -> "unknown"         
         * GetHerd("walrus") -> "unknown"
         * GetHerd("Rhino") -> "Crash"
         * GetHerd("rhino") -> "Crash"
         * GetHerd("elephants") -> "unknown"
         * 
         */
        public string GetHerd(string animalName)
        {
            Dictionary<string, string> animals = new Dictionary<string, string>()
            {
                {"rhino", "Crash" },
                {"giraffe", "Tower" },
                {"elephant", "Herd" },
                {"lion", "Pride" },
                {"crow", "Murder" },
                {"pigeon", "Kit" },
                {"flamingo", "Pat" },
                {"deer", "Herd" },
                {"dog", "Pack" },
                {"crocodile", "Float" },
            };

            if (animals.ContainsKey(animalName.ToLower()))
            {
                return animals[animalName.ToLower()];
            }
            else
            {
                return "unknown";
            }
        }
    }
}
