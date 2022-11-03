using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Repositories
{
    public class ReferenciaPago
    {
        public string GenRef(string userid,ApplicationDbContext context)
        {
            string dataS = null;
            int lim = new Random().Next(6);
            if (lim == 0)
            {
                lim++;
            }
            int data = new Random().Next(999999);
            var name = context.Users.Find(userid);
            for(int i = 0; i < lim;i++)
            {
                dataS += name.UserName[i];
            }
            string final = data.ToString() + dataS.ToUpper();
            return final;
        }
    }
}
