using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class UsedPromos
    {
        public int id { get; set; }
        public string UserID { get; set; }
        public string PromoCodeID { get; set; }
        public bool UsedCode { get; set; }
    }
}
