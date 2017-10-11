using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDB.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Id.ToString().PadRight(10) + Name.PadRight(40);
        }
    }
}
