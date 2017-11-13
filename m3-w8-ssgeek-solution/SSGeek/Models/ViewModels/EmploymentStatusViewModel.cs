using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SSGeek.Models.ViewModels
{
    public class EmploymentStatusViewModel
    {
        [Required(ErrorMessage = "* required")]
        [Display(Name = "Employment Status")]
        public string EmploymentStatus { get; set; }

        [Required(ErrorMessage = "* required")]
        [DataType(DataType.Text)]
        [Display(Name = "Last Employer")]
        public string LastEmployer { get; set; }

        [Required(ErrorMessage = "* required")]
        [DataType(DataType.Text)]
        [Display(Name = "City")]
        public string LastEmployerCity { get; set; }

        [Required(ErrorMessage = "* required")]
        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime LastEmployerStartDate { get; set; }

        [Required(ErrorMessage = "* required")]
        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTime LastEmployerEndDate { get; set; }
    }
}