using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SSGeek.Models.ViewModels
{
    public class ContactInfoViewModel
    {
        [Required(ErrorMessage = "* required")]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "* required")]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "* required")]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required(ErrorMessage = "* required")]
        [RegularExpression(@"\d{5}-?(\d{4})?$", ErrorMessage = "* not valid zip code")]
        [DataType(DataType.Text)]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "* required")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Compare("Email", ErrorMessage = "* email does not match")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Confirm Email")]
        public string ConfirmEmail { get; set; }
    }
}