using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ComponentesMexica.Data;
using ComponentesMexica.Data.Models;
using ComponentesMexica.Data.ViewModels;
using Microsoft.AspNetCore.Identity;
using ComponentesMexica.Data.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace ComponentesMexica.Controllers
{
    [Authorize]
    public class VendedorsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IWebHostEnvironment webHostEnvironment;
        protected GenId gen = new GenId();
        protected ImageUploader uploader = new ImageUploader();
        protected MailSender sender = new MailSender();
        public VendedorsController(ApplicationDbContext context,UserManager<IdentityUser> user,IWebHostEnvironment web)
        {
            _context = context;
            userManager = user;
            webHostEnvironment = web;
        }
        [Authorize(Roles ="Admin")]
        // GET: Vendedors
        public IActionResult Index()
        {
            var data = _context.Vendedor.ToList().Where(p => p.Active == true && p.Aceptado == true);
            return View(data);
        }
        [Authorize(Roles ="Admin")]
        public IActionResult Solicitudes()
        {
            var data = _context.Vendedor.ToList().Where(p=>p.Aceptado==false);
            return View(data);
        }
        [Authorize(Roles ="Admin")]
        public IActionResult Deny(string id)
        {
            var data = _context.Vendedor.FirstOrDefault(p=>p.Aceptado==false&&p.id==id);
            data.Aceptado = false;
            sender.SendMailDenySeller(id,data);
            _context.Update(data);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> Accept(string id)
        {
            var data = await _context.Vendedor.FirstOrDefaultAsync(p=>p.Aceptado==false && p.id==id);
            data.Aceptado = true;
            var user = await _context.Users.FindAsync(data.userid);
            sender.SendMailAceptSeller(user.Id,data);
            await userManager.AddToRoleAsync(user,"Seller");
            _context.Vendedor.Update(data);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Ocultos()
        {
            var data = _context.Vendedor.ToList().Where(p=>p.Active==false);
            return View(data);
        }
        [Authorize(Roles ="Admin")]
        public IActionResult ShowSeller(string id)
        {
            var data = _context.Vendedor.FirstOrDefault(p=>p.Active==false&&p.id==id);
            data.Active = true;
            _context.Update(data);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vendedors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(VendedorViewModel vm)
        {
            var userid = userManager.GetUserId(HttpContext.User);
            var datas = _context.Vendedor.FirstOrDefault(p => p.userid == userid);
            var usermail = _context.Users.Find(userid);
            if (datas != null)
            {
                var error = new ErrorVM()
                {
                    DataError = "Vendedor ya registrado, contacta con nosotros en caso de existir un error con tu solicitud"
                };
                return RedirectToAction("Error",error);
            }
            var data = new Vendedor()
            {
                id = gen.SetId(_context),
                Active = true,
                Aceptado=false,
                Nombre = vm.Nombre,
                Apellidos = vm.Apellidos,
                Curp = vm.Curp,
                ImagenINE = uploader.UploadSelleInePic(vm,webHostEnvironment),
                INE = vm.INE,
                Mail=usermail.Email,
                Numero = vm.Numero,
                Registro = DateTime.Now,
                userid = userManager.GetUserId(HttpContext.User)
            };
            _context.Add(data);
            _context.SaveChanges();
            sender.SendMailAdminSellerRegister(data.userid,data);
            return RedirectToAction("Complete",data);
        }
        public IActionResult Error(ErrorVM vm)
        {
            ViewBag.data = vm.DataError;
            return View();
        }

        public IActionResult Complete(Vendedor data)
        {
            return View(data);
        }
        [Authorize(Roles ="Admin")]
        public IActionResult SellerProducts(string id)
        {
            var data = _context.SecondHand.ToList().Where(p=>p.SellerId==id);
            return View(data);
        }
        [Authorize(Roles ="Admin")]
        public IActionResult HideSeller(string id)
        {
            var data = _context.Vendedor.FirstOrDefault(p => p.id == id);
            data.Active = false;
            _context.Vendedor.Update(data);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Details(string id)
        {
            var data = _context.Vendedor.FirstOrDefault(p=>p.id==id);
            return View(data);
        }
        // GET: Vendedors/Delete/5
        [Authorize(Roles ="Admin")]
        private bool VendedorExists(string id)
        {
            return _context.Vendedor.Any(e => e.id == id);
        }
    }
}
