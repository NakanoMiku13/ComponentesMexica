using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Repositories
{
    public class BackUp
    {
        public void Data(BackUpContext ctx,ApplicationDbContext context) 
        {
            var Employees = context.Employee.ToList();
            var IdentityUser = context.Users.ToList();
            var IdentityRoles = context.Roles.ToList();
            var IdentityUserRoles = context.UserRoles.ToList();
            var Privileges = context.Privilege.ToList();
            var Entidades = context.Entidad.ToList();
            var Category = context.Category.ToList();
            var Edited = context.Edit.ToList();
            
        }
    }
}
