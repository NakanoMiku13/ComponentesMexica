using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class Componente
    {
        public int id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Subido { get; set; }
        public bool Active { get; set; }
        public string Employeeid { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal ComisionPay { get; set; }
        public decimal Ganancia { get; set; }
        public string Imagen { get; set; }
        public bool Revision { get; set; }
        public int Calificacion { get; set; }
        public string Formato { get; set; }
        public int Capacidad { get; set; }
        public int Wattage { get; set; }
        public string Socket { get; set; }
        public int Categoryid { get; set; }
        public Category Category { get; set; }
    }
}
