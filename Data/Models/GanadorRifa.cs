using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class GanadorRifa
    {
        public string id { get; set; }
        public string userid { get; set; }
        public string Rifaid { get; set; }
        public int CantidadTickets { get; set; }
        public int NumeroWin { get; set; }
    }
}
