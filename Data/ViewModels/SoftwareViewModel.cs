using ComponentesMexica.Data.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.ViewModels
{
    public class SoftwareViewModel
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public IFormFile Imagen { get; set; }
        public int Categoryid { get; set; }
        public Category Category { get; set; }
    }
}
