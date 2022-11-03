using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class SecondHand
    {
        public string id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public string Imagen { get; set; }
        public bool Active { get; set; }
        public bool Enviado { get; set; }
        public int Calificacion { get; set; }
        public bool Entregado { get; set; }
        public int Reportesid { get; set; }
        public int Categoryid { get; set; }
        public DateTime Posted { get; set; }
        public string SellerId { get; set; }
    }
}
