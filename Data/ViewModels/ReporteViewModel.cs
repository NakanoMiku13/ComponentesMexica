using ComponentesMexica.Data.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.ViewModels
{
    public class ReporteViewModel
    {
        public IFormFile Evidencia1 { get; set; }
        public IFormFile Evidencia2 { get; set; }
        public IFormFile Evidencia3 { get; set; }
        public string Sellerid { get; set; }
        public string ReporteData { get; set; }
        public string ReferenciaPago { get; set; }
        public SecondHand Producto { get; set; }
    }
}
