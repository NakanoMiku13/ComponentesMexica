using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class Reporte
    {
        public string id { get; set; }
        public string Nombre { get; set; }
        public string Orderid { get; set; }
        public string userid { get; set; }
        public string Evidencia1 { get; set; }
        public string Evidencia2 { get; set; }
        public string Evidencia3 { get; set; }
        public string UserMail { get; set; }
        public DateTime Report { get; set; }
        public string ReporteData { get; set; }
        public string Referencia { get; set; }
        public string Sellerid { get; set; }
        public string ReferenciaPago { get; set; }
    }
}
