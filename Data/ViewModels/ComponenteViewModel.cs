using ComponentesMexica.Data.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.ViewModels
{
    public class ComponenteViewModel
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public bool Active { get; set; }
        public decimal PrecioCompra { get; set; }
        public IFormFile Imagen { get; set; }
        public string Formato { get; set; }
        public int Capacidad { get; set; }
        public int Wattage { get; set; }
        public string Socket { get; set; }
        public int Categoryid { get; set; }
        public Category Category { get; set; }
    }
}
