using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class PCMR
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string CPU { get; set; }
        public string Mobo { get; set; }
        public string GPU { get; set; }
        public string PCU { get; set; }
        public string RAM { get; set; }
        public string RAM1 { get; set; }
        public string RAM2 { get; set; }
        public string RAM3 { get; set; }
        public string Cooler { get; set; }
        public string SSDM2 { get; set; }
        public string Almacenamiento { get; set; }
        public string AlmacenamientoSecu { get; set; }
        public string Case { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioComision { get; set; }
        public decimal Ganancia { get; set; }
        public decimal Comision { get; set; }
        public string EmployeeId { get; set; }
        public DateTime Published { get; set; }
        public bool Active { get; set; }
        public string Imagen { get; set; }
    }
}
