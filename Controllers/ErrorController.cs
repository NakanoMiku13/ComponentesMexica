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
    public class ErrorController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<IdentityUser> userManager;
        protected MailSender sender = new MailSender();
        protected GenId gen = new GenId();
        public ErrorController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }
        protected string GetUser()
        {
            return userManager.GetUserId(HttpContext.User);
        }
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> Index()
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró en Index/Error", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var data = await context.Reporters.ToListAsync();
            return View(data);
        }
        [Authorize]
        public async Task<IActionResult> Report()
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró en Report/Error", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            return View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Report(ErrorReporter report)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario creó un reporte", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var userid = userManager.GetUserId(HttpContext.User);
            var rep = new ErrorReporter()
            {
                id = gen.SetId(context),
                userid=userid,
                Reported=DateTime.Now,
                Error=report.Error
            };
            await context.AddAsync(rep);
            await context.SaveChangesAsync();
            sender.SendError(userid,report);
            return RedirectToAction(nameof(Complete));
        }
        public async Task<IActionResult> Complete()
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario finalizó el reporte", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            return View();
        }
    }
}
