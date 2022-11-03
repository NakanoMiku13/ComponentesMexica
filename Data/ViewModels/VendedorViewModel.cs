using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.ViewModels
{
    public class VendedorViewModel
    {
        public string userid { get; set; }
        public string Nombre { get; set; }
        public string INE { get; set; }
        public IFormFile ImagenINE { get; set; }
        public string Curp { get; set; }
        public string Apellidos { get; set; }
        public string Numero { get; set; }
        public bool TerminosYCondiciones { get; set; }
    }
}
