using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ComponentesMexica.Models;
using ComponentesMexica.Data;
using ComponentesMexica.Data.Repositories;
using ComponentesMexica.Data.ViewModels;
using Microsoft.AspNetCore.Identity;
using ComponentesMexica.Data.Models;

namespace ComponentesMexica.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext context;
        private readonly UserManager<IdentityUser> userManager;
        protected CAU c = new CAU();
        public HomeController(ILogger<HomeController> logger,ApplicationDbContext contxt, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            context = contxt;
            this.userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró en Index/Home", Logged = DateTime.Now, userid = null };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            c.Create(context,userManager);
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
