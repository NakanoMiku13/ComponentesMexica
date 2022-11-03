using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComponentesMexica.Data;
using ComponentesMexica.Data.Models;
using ComponentesMexica.Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComponentesMexica.Controllers
{
    [Authorize(Roles ="Admin")]
    public class EditedController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<IdentityUser> userManager;
        public EditedController(ApplicationDbContext context,UserManager<IdentityUser>user)
        {
            this.context = context;
            userManager = user;
        }
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> Index()
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró en Index/Edited", Logged = DateTime.Now, userid = userManager.GetUserId(HttpContext.User) };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var data = await context.Edit.ToListAsync();
            return View(data);
        }

    }
}
