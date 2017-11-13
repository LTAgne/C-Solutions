using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SSGeek.Models
{
    public class AlienWeightModel
    {
        [Display(Name = "Choose a planet")]
        public string AlienPlanet { get; set; }

        [Display(Name = "Enter your Earth weight")]
        public double EarthWeight { get; set; }

        public double AlienWeight
        {
            get { return EarthWeight * weightEffects[AlienPlanet.ToLower()]; }
        }


        Dictionary<string, double> weightEffects = new Dictionary<string, double>
            {
                {"mercury", 0.37 },
                {"venus", 0.90 },
                {"earth", 1.00 },
                {"mars", 0.38 },
                {"jupiter", 2.65 },
                {"saturn", 1.13 },
                {"uranus", 1.09 },
                {"neptune", 1.43 }
            };


        
    }
}