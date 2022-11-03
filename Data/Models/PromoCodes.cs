using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class PromoCodes
    {
        public int id { get; set; }
        public string Code { get; set; }
        public int Desc { get; set; }
        public string EmployeeID { get; set; }
        public bool Active { get; set; }
        public DateTime Published { get; set; }
    }
}
