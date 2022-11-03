using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Repositories
{
    public class NomiRefe
    {
        public string SetId()
        {
            string id = Character();
            return id;
        }
        protected int Lengt()
        {
            int data = new Random().Next(10);
            return data;
        }
        protected string Character()
        {
            string id = null;
            for (int i = 0; i < 5; i++)
            {
                int y = Lengt();
                for (int j = 0; j < y; j++)
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
            int datas = new Random().Next(97, 126);
            return datas;
        }
    }
}
