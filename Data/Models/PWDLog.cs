using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class PWDLog
    {
        public string Id { get; set; }
        public string Pwd { get; set; }
        public DateTime Date { get; set; }
        public bool Valid { get; set; }
    }
}
