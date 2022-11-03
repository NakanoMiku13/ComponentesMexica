using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class SellerM
    {
        public string id { get; set; }
        public string Sellerid { get; set; }
        public string Referencia { get; set; }
        public DateTime Updated { get; set; }
        public decimal Total { get; set; }
        public bool Retired { get; set; }
    }
}
