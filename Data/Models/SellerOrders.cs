using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class SellerOrders
    {
        public string id { get; set; }
        public string sellerid { get; set; }
        public string Prodid { get; set; }
        public bool Enviado { get; set; }
        public bool Oculto { get; set; }
        public string userid { get; set; }
        public string RefPago { get; set; }
        public string orderid { get; set; }
    }
}
