using ComponentesMexica.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.ViewModels
{
    public class SearchViewModel
    {
        public Employee Employee { get; }
        public string Cadena { get; set; }
    }
}
