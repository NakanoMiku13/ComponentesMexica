using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class VentasSecondHand
    {
        public string id { get; set; }
        public string SellerId { get; set; }
        public int OrderId { get; set; }
        public string UserId { get; set; }
        public string ProductoId { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal Comision { get; set; }
        public DateTime Fecha { get; set; }
    }
}
