using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Component
{
    public class PlusMenu:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
