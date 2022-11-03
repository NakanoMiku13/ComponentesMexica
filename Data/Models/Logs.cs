using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class Logs
    {
        public string id { get; set; }
        public string log { get; set; }
        public string userid { get; set; }
        public DateTime Logged { get; set; }
    }
}
