using ComponentesMexica.Data.Models;
using Microsoft.EntityFrameworkCore;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ComponentesMexica.Data.Repositories
{
    public class PreLoadEntityData
    {
        public void Load(ApplicationDbContext context)
        {
            var datas = context.DataEntity.FirstOrDefault(p=>p.id==1);
            if (datas!=null)
            {

            }
            else if (datas == null) 
            {
                string Path = @"D:\ComponentesMexica\wwwroot\Data\Data.xlsx";
                SLDocument sL = new SLDocument(Path);
                int iRow = 2;
                int c = 0;
                while (!string.IsNullOrEmpty(sL.GetCellValueAsString(iRow, 1)))
                {
                    if ((c % 50000 == 0) && c!=0)
                    {
                        context.SaveChanges();
                    }
                    var Entidad = new Entidades()
                    {
                        DataI = sL.GetCellValueAsString(iRow, 1),
                        Asenta = sL.GetCellValueAsString(iRow, 2),
                        TipoAsenta = sL.GetCellValueAsString(iRow, 3),
                        Municipio = sL.GetCellValueAsString(iRow, 4),
                        Estado = sL.GetCellValueAsString(iRow, 5),
                        Ciudad = sL.GetCellValueAsString(iRow, 6),
                        CP = sL.GetCellValueAsString(iRow, 7),
                        CEstado = sL.GetCellValueAsString(iRow, 8)
                    };
                    context.Add(Entidad);
                    iRow++;
                    c++;
                }
                var data = new EntityDataLoaded();
                data.Complete = true;
                context.DataEntity.Add(data);
                context.SaveChanges();
            }
        } 
    }
}
