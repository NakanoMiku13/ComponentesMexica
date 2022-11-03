using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.ViewModels
{
    public class SecondHandViewModel
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public int Categoryid { get; set; }
        public bool Active { get; set; }
        public IFormFile Imagen { get; set; }
    }
}
