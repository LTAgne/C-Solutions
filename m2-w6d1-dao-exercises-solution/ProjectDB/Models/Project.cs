using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDB.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public override string ToString()
        {
            return ProjectId.ToString().PadRight(5) + Name.PadRight(35) + StartDate.ToShortDateString().PadRight(15) + EndDate.ToShortDateString().PadRight(15);
        }
    }
}
