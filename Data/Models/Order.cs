using DocumentFormat.OpenXml.Office.CoverPageProps;
using DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class Order
    {
        public int id { get; set; }
        public string userid { get; set; }
        public string Nombre { get; set; }
        public string Mail { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }
        public string Colonia { get; set; }
        public string CP { get; set; }
        public string Numero { get; set; }
        public bool Politicas { get; set; }
        public bool Entregado { get; set; }
        public string MetodoPago { get; set; }
        public bool Acreditado { get; set; }
        public bool Enviado { get; set; }
        public decimal Total { get; set; }
        public DateTime Ordenado { get; set; }
        public DateTime EntregaEstimada { get; set; }
        public string MetodoEnvio { get; set; }
        public string RefPago { get; set; }
        public bool Devolucion { get; set; }
        public bool Cancelado { get; set; }
        public bool Visible { get; set; }
    }
}
