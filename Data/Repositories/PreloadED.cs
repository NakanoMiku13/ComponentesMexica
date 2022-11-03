using ComponentesMexica.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Repositories
{
    public class PreloadED
    {
        public void Load(ApplicationDbContext context)
        {
            string[] Roles = { "Manager", "Seller", "" };
            int i = 0;
            while (!string.IsNullOrEmpty(Roles[i]))
            {
                var data = new Privilege()
                {
                    Name = Roles[i]
                };
                context.Add(data);
                context.SaveChanges();
                var role = new IdentityRole()
                {
                    Name = Roles[i],
                    NormalizedName = Roles[i].ToUpper()
                };
                context.Add(role);
                context.SaveChanges();
                i++;
            }
        }
    }
}
