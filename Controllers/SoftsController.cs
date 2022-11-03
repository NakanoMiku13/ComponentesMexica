using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComponentesMexica.Data;
using Microsoft.AspNetCore.Mvc;

namespace ComponentesMexica.Controllers
{
    public class SoftsController : Controller
    {
        private readonly ApplicationDbContext context;
        public SoftsController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var data = context.Softwares.ToList();
            return View(data);
        }
    }
}
