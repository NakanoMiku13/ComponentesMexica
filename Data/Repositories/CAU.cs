using DocumentFormat.OpenXml.Office2010.Drawing;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Repositories
{
    public class CAU
    {
        private string Mail()
        {
            return "danulricht@hotmail.com";
        }
        private string Role()
        {
            return "Admin";
        }
        private string Hash()
        {
            return "AQAAAAEAACcQAAAAEDPV3rfMxn2Ujt9J85myHHiBBCiepFch9Oy6RvDJmlbLAgRS5/qhEBiXA3cRU1TEPA==";
        }
        private void Data(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            var x = context.Users.FirstOrDefault(p => p.Email == Mail());
            if (x == null)
            {
                var User = new IdentityUser()
                {
                    Email = Mail(),
                    NormalizedEmail = Mail().ToUpper(),
                    UserName = Mail(),
                    NormalizedUserName = Mail().ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = Hash()
                };
                var Roles = new IdentityRole()
                {
                    Name = Role(),
                    NormalizedName = Role().ToUpper()
                };
                
                context.Add(User);
                context.Add(Roles);
                context.SaveChanges();
                var UserRoles = new IdentityUserRole<string>() { RoleId = Roles.Id, UserId = User.Id };
                context.Add(UserRoles);
                context.SaveChanges();
            }
        }
        public void Create(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            Data(context, userManager);
        }
    }
}
