using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class ErrorReporter
    {
        public string id { get; set; }
        public string userid { get; set; }
        public DateTime Reported { get; set; }
        public string Error { get; set; }
    }
}
