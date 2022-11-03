using ComponentesMexica.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Repositories
{
    public class LastOne
    {
        public Componente componente(int id,ApplicationDbContext context)
        {
            var data = context.Componente.FirstOrDefault(p=>p.id==id);
            return data;
        }
    }
}
