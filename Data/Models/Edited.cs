using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class Edited
    {
        public int id { get; set; }
        public int Componenteid { get; set; }
        public string Employeeid { get; set; }
        public string Edit { get; set; }
        public DateTime EditedTime { get; set; }
        public bool Deleted { get; set; }
    }
}
