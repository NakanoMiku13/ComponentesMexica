using ComponentesMexica.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.TempModels
{
    public class TempComponent
    {
        public int id { get; set; }
        public int CompID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime Subido { get; set; }
        public bool Active { get; set; }
        public string Employeeid { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal ComisionPay { get; set; }
        public decimal Ganancia { get; set; }
        public string Imagen { get; set; }
        public int Categoryid { get; set; }
    }
}
