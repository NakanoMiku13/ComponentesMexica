using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComponentesMexica.Data;
using ComponentesMexica.Data.Models;
using ComponentesMexica.Data.Repositories;
using ComponentesMexica.Data.ViewModels;
using DocumentFormat.OpenXml.Bibliography;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ComponentesMexica.Controllers
{
    public class SoftwareController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly UserManager<IdentityUser> userManager;
        protected ImageUploader uploader = new ImageUploader();
        protected MailSender sender = new MailSender();
        public SoftwareController(ApplicationDbContext context,IWebHostEnvironment WEB,UserManager<IdentityUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
            webHostEnvironment = WEB;
        }
        [Authorize(Roles ="Admin")]
        public IActionResult Index()
        {
            var data = context.Softwares.ToList();
            return View(data);
        }
        [Authorize(Roles ="Admin")]
        public IActionResult Create()
        {
            ViewData["Categoryid"] = new SelectList(context.Category,"id","Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(SoftwareViewModel vm)
        {
            var data = new Software()
            {
                Active = true,
                employeeid =userManager.GetUserId(HttpContext.User),
                Categoryid = vm.Categoryid,
                Imagen = uploader.UploadSoftwarePic(vm,webHostEnvironment),
                Nombre = vm.Nombre,
                Precio = vm.Precio,
                Published = DateTime.Now
            };
            context.Add(data);
            context.SaveChanges();
            sender.SendMailSoftwareAdded(data.employeeid,data);
            ViewData["Categoryid"] = new SelectList(context.Category, "id", "Name",vm.Categoryid);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var data = context.Softwares.Find(id);
            if (data == null)
            {
                return View("Error");
            }
            ViewData["Categoryid"] = new SelectList(context.Category, "id", "Name");
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(Software soft)
        {
            context.Update(soft);
            context.SaveChanges();
            ViewData["Categoryid"] = new SelectList(context.Category, "id", "Name", soft.Categoryid);
            return RedirectToAction("Index");
        }
    }
}
