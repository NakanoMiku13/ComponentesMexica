using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class Software
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Imagen { get; set; }
        public bool Active { get; set; }
        public DateTime Published { get; set; }
        public string employeeid { get; set; }
        public int Categoryid { get; set; }
        public Category Category { get; set; }
    }
}
