using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ComponentesMexica.Controllers
{
    public class WorkInProgressController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
