using ComponentesMexica.Data.Models;
using ComponentesMexica.Data.TempModels;
using DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Repositories
{
    public class TempData
    {
        public void TempDataComponent(ApplicationDbContext context,Componente c)
        {
            var data = new TempComponent()
            {
                CompID = c.id,
                Active = c.Active,
                Categoryid = c.Categoryid,
                ComisionPay = c.ComisionPay,
                PrecioCompra = c.PrecioCompra,
                Employeeid = c.Employeeid,
                Ganancia = c.Ganancia,
                Imagen = c.Imagen,
                Marca = c.Marca,
                Modelo = c.Modelo,
                PrecioVenta = c.PrecioVenta,
                Subido = c.Subido
            };
            context.tempComponents.Add(data);
            context.SaveChanges();
        }
        public void DeleteTempData(int id,ApplicationDbContext context)
        {
            var data = context.tempComponents.FirstOrDefault(p=>p.CompID==id);
            context.tempComponents.Remove(data);
            context.SaveChanges();
        }
    }
}
