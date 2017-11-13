using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SSGeek.Models
{
    public class AlienTravelModel
    {
        [Display(Name = "Choose a planet")]
        public string AlienPlanet { get; set; }

        [Display(Name = "Choose a mode of transport")]
        public string ModeOfTransport { get; set; }

        [Display(Name = "Enter your Earth age")]
        public int EarthAgeInYears { get; set; }

        Dictionary<string, long> distances = new Dictionary<string, long>
        {
            {"mercury", 56974146 },
            {"venus", 74402987 },
            {"mars", 48678219 },
            {"jupiter", 390674710 },
            {"saturn", 792248270 },
            {"uranus", 1692662530 },
            {"neptune", 2703959960 },
        };

        Dictionary<string, int> mph = new Dictionary<string, int>
        {
            {"walking", 3 },
            {"car", 100 },
            {"bullet train", 200 },
            {"boeing 747", 570 },
            {"concorde", 1350 }
        };

        public double GetDriveTimeInYears()
        {
            long distance = distances[AlienPlanet.ToLower()];
            int speed = mph[ModeOfTransport.ToLower()];

            int hours = (int)(distance / speed);
            TimeSpan ts = new TimeSpan(hours, 0, 0);

            return ts.TotalDays / 365;
        }

        public double GetFinalEarthAge()
        {
            double driveTimeInYears = GetDriveTimeInYears();
            return EarthAgeInYears + driveTimeInYears;
        }
    }
}