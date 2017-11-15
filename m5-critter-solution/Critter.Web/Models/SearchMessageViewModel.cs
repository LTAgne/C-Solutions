using Critter.Web.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Critter.Web.Models
{
    public class SearchMessageViewModel
    {
        public string Username { get; set; }
        public string Text { get; set; }

        public List<Message> Messages { get; set; } = new List<Message>();
    }
}