using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SSGeek.Models.ViewModels
{
    public class ConfirmPrivacyViewModel
    {
        [Range(typeof(bool), "true", "true", ErrorMessage = "* you must check the box")]
        [Display(Name = "Background check approval")]
        public bool DoBackgroundCheck { get; set; }

        [Display(Name = "Please send me periodic emails")]
        public bool SendEmails { get; set; }
    }
}