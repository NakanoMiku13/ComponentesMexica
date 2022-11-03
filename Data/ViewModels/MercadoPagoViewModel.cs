using ComponentesMexica.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.ViewModels
{
    public class MercadoPagoViewModel
    {
        public Order Order { get; set; }
        public string Titular { get; set; }
        public int MesVenci { get; set; }
        public int AnoVenc { get; set; }
        public string NumCard { get; set; }
        public int CVV { get; set; }
        public string Doctype { get; set; }
        public string Number { get; set; }
        public int Installments { get; set; }
        public string Paymethodid { get; set; }
        public string Token { get; set; }
        public string Description { get; set; }
        public decimal Total { get; set; }
    }
}
