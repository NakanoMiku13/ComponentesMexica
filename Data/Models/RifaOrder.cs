using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class RifaOrder
    {
        public string id { get; set; }
        public string userid { get; set; }
        public int CantTickets { get; set; }
        public bool Visible { get; set; }
        public decimal total { get; set; }
        public bool Acreditado { get; set; }
        public string ReferenciaPago { get; set; }
        public string Rifaid { get; set; }
    }
}
