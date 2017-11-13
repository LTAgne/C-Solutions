using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace SSGeek.Models
{
    public class AlienAgeModel
    {
        [Display(Name = "Choose a planet")]
        public string AlienPlanet { get; set; }

        [Display(Name = "Enter your Earth age")]
        public int EarthAgeInYears { get; set; }



        Dictionary<string, double> ageEffects = new Dictionary<string, double>
            {
                {"mercury", 87.96 / 365.26},
                {"venus", 224.68 / 365.26 },
                {"earth", 1.0 },
                {"mars", 365.26 / 686.98 },
                {"jupiter", 11.862},
                {"saturn", 29.456},
                {"uranus", 84.07 },
                {"neptune", 247.7}
            };


        public double GetAlienAge()
        {
            double coefficient = ageEffects[AlienPlanet.ToLower()];
            return EarthAgeInYears / coefficient;
            
        }

    }
}