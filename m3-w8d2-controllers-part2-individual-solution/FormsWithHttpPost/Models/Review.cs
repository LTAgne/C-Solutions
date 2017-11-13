using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormsWithHttpPost.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int Rating { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}