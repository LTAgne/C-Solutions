using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critter.Web.Models.Data
{
    public class Message
    {
        public int MessageId { get; set; }        
        public string Sender { get; set; }
        public bool IsPrivate { get; set; }
        public string Recipient { get; set; }
        public string MessageText { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
