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
    [Authorize]
    public class ContactosController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<IdentityUser> userManager;
        protected MailSender sender = new MailSender();
        public ContactosController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }
        protected string GetUser()
        {
            return userManager.GetUserId(HttpContext.User);
        }
        [Authorize]
        public async Task<IActionResult> SendMessage()
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró en SendMessage/Contactos", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            return View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SendMessage(Contacto contacto)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario envió mensaje", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var userid = GetUser();
            var data = context.Users.Find(userid);
            contacto.Email = data.Email;
            contacto.userid = userid;
            await context.AddAsync(contacto);
            await context.SaveChangesAsync();
            sender.SendMailMessage(userid,contacto);
            return RedirectToAction("Index","Home");
        }
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> Index()
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró en Index/Contactos", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var data = await context.Contactos.ToListAsync();
            return View(data);
        }
    }
}
