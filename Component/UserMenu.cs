
using ComponentesMexica.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Component
{
    public class UserMenu:ViewComponent
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<IdentityUser> userManager;
        public UserMenu(ApplicationDbContext context,UserManager<IdentityUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }
        public IViewComponentResult Invoke()
        {
            bool active = false;
            var userid = userManager.GetUserId(HttpContext.User);
            var userRole = context.UserRoles.FirstOrDefault(p => p.UserId == userid);
            if (userRole == null)
            {
                ViewBag.Role = "user";
                active = false;
            }
            else
            {
                var role = context.Roles.Find(userRole.RoleId);
                ViewBag.Role = role.Name;
                active = true;
            }
            ViewBag.Data = active;
            return View();
        }
    }
}
