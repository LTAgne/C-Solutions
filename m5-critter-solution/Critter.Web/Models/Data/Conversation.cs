using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critter.Web.Models.Data
{
    public class Conversation
    {
        public string ForUser { get; set; }
        public string WithUser { get; set; }
        public List<Message> Messages { get; set; } = new List<Message>();

        
    }
}
