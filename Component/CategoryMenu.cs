using ComponentesMexica.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Component
{
    public class CategoryMenu:ViewComponent
    {
        private readonly ApplicationDbContext context;
        public CategoryMenu(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IViewComponentResult Invoke()
        {
            var data = context.Category.ToList();
            return View(data);
        }
    }
}
