using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class Vendedor
    {
        public string id { get; set; }
        public string userid { get; set; }
        public string Nombre { get; set; }
        public string INE { get; set; }
        public string ImagenINE { get; set; }
        public string Mail { get; set; }
        public string Curp { get; set; }
        public string Apellidos { get; set; }
        public string Numero { get; set; }
        public DateTime Registro { get; set; }
        public int Calificacion { get; set; }
        public bool Active { get; set; }
        public bool TerminosYCondiciones { get; set; }
        public bool Aceptado { get; set; }
    }
}
