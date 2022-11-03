using ComponentesMexica.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Repositories
{
    public class GenId
    {
        public string SetId(ApplicationDbContext context)
        {
            string id = Character();
            var lookdata = context.Identificador.FirstOrDefault(p=>p.Identificador==id);
            if (lookdata != null)
            {
                for (int i = 0; i < 2; i++)
                {
                    id += Character();
                }
            }
            var data = new Identificadores()
            {
                Identificador = id
            };
            context.Add(data);
            context.SaveChanges();
            return id;
        }
        public string PWD(ApplicationDbContext context)
        {
            string pwd = Character();
            var Log = new PWDLog()
            {
                Date = DateTime.Now,
                Id = Character(),
                Pwd = pwd,
                Valid = true
            };
            context.Add(Log);
            context.SaveChanges();
            return pwd;
        }
        protected int Lengt()
        {
            int data = new Random().Next(10);
            return data;
        }
        protected string Character()
        {
            string id = null;
            for(int i = 0; i < 4; i++)
            {
                int y = Lengt();
                for (int j = 0;j < y;j++)
                {
                    id += Lengt().ToString();
                    int x = new Random().Next(2);
                    if (x == 0)
                    {
                        id += (char)Numero1();
                    }
                    else
                    {
                        id += (char)Numero();
                    }
                }
                id += '-';
                id += Lengt().ToString();
            }
            return id;
        }
        protected int Numero()
        {
            int datas = new Random().Next(65, 96);
            return datas;
        }
        protected int Numero1()
        {
            int datas = new Random().Next(97,126);
            return datas;
        }
    }
}
