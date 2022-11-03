using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class Tickets
    {
        public int id { get; set; }
        public string userid { get; set; }
        public string Rifaid { get; set; }
        public int Numero { get; set; }
        public decimal Costo { get; set; }
        public DateTime Comprado { get; set; }
    }
}
