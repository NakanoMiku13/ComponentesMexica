using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class SellerReports
    {
        public string id { get; set; }
        public string useridSeller { get; set; }
        public string reportid { get; set; }
        public int Cuenta { get; set; }
        public string Sellerid { get; set; }
    }
}
