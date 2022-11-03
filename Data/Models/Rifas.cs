using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class Rifas
    {
        public string id { get; set; }
        public int Numero { get; set; }
        public int Componenteid { get; set; }
        public Componente Componente { get; set; }
        public string GanadorUserid { get; set; }
        public DateTime Rifado { get; set; }
        public int Tickets { get; set; }
        public decimal Acumulado { get; set; }
        public int NumeroWin { get; set; }
        public bool Active { get; set; }
        public decimal CostoTicket { get; set; }
    }
}
