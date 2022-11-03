using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class SellerRetire
    {
        public string id { get; set; }
        public string Sellerid { get; set; }
        public bool Aproved { get; set; }
        public bool Termino { get; set; }
        public DateTime Solicitado { get; set; }
        public string Employeeid { get; set; }
        public decimal Total { get; set; }
        public string Mail { get; set; }
        public string Metodo { get; set; }
        public string ReferenciaSeller { get; set; }
        public string ReferenciaRetiro { get; set; }
    }
}
