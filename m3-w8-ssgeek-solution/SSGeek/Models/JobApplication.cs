using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSGeek.Models
{
    public class JobApplication
    {
        // Contact Information
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }

        // Employment History
        public string EmploymentStatus { get; set; }
        public string LastEmployer { get; set; }
        public string LastEmployerCity { get; set; }
        public DateTime LastEmployerStartDate { get; set; }
        public DateTime LastEmployerEndDate { get; set; }


        // Required Checkboxes
        public bool DoBackgroundCheck { get; set; }
        public bool SendEmails { get; set; }
    }
}