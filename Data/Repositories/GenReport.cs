using DocumentFormat.OpenXml.Wordprocessing;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Repositories
{
    public class GenReport
    {
        public void SetReport()
        {
            
        }
        public void SetLog(ApplicationDbContext context)
        {
            TextWriter Write = new StreamWriter("Log.txt");
            int lines = context.Logs.Count();
            var data = context.Logs.ToList().OrderBy(p=>p.Logged.Year);
            Write.WriteLine("Anexando "+lines.ToString()+" logs en total, ordenados del más reciente al más antiguo.");
            Write.WriteLine("ID | User id | Log | Fecha");
            foreach(var i in data)
            {
                string text = null;
                if (i.userid == null)
                {
                    text += i.id + " not defined " + i.log + " " + i.Logged.ToString() + "\n";
                }
                else
                {
                    text += i.id + " " + i.userid + " " + i.log + " " + i.Logged.ToString() + "\n";
                }
                
                Write.WriteLine(text);
            }
            Write.Close();
        }
    }
}
