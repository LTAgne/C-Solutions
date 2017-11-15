using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Critter.Web.Models
{
    public class NewMessageViewModel
    {

        [Required]
        public bool IsPrivate { get; set; }

        public string Recipient { get; set; }

        [Required]
        [MaxLength(140)]
        public string MessageText { get; set; }
    }
}