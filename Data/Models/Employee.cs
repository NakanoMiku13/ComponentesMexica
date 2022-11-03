using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class Employee
    {
        public string id { get; set; }
        public string Mail { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string INE { get; set; }
        public string Numero { get; set; }
        public int Privilegeid { get; set; }
        public Privilege Privilege { get; set; }
        public bool Activo { get; set; }
        public DateTime HireDate { get; set; }
        public string Imagen { get; set; }
        public string Cadena { get; set; }
    }
}
