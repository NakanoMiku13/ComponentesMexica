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
using DocumentFormat.OpenXml.Bibliography;
using Microsoft.AspNetCore.Identity;
using ComponentesMexica.Data.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace ComponentesMexica.Controllers
{
    [Authorize(Roles ="Admin,Seller")]
    public class SecondHandsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IWebHostEnvironment webHostEnvironment;
        protected MailSender sender = new MailSender();
        protected Prices sell = new Prices();
        protected ImageUploader uploader = new ImageUploader();
        protected GenId gen = new GenId();
        public SecondHandsController(ApplicationDbContext context, UserManager<IdentityUser> userManager, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            this.userManager = userManager;
            this.webHostEnvironment = webHostEnvironment;
        }
        [Authorize(Roles = "Admin,Seller")]
        // GET: SecondHands
        public IActionResult Index()
        {
            var userid=userManager.GetUserId(HttpContext.User);
            var data = _context.SecondHand.Where(p => p.SellerId == userid).ToList();
            return View(data);
        }
        [Authorize(Roles = "Admin,Seller")]
        // GET: SecondHands/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var secondHand = await _context.SecondHand
                .FirstOrDefaultAsync(m => m.id == id);
            if (secondHand == null)
            {
                return NotFound();
            }

            return View(secondHand);
        }
        [Authorize(Roles = "Admin,Seller")]
        // GET: SecondHands/Create
        public IActionResult Create()
        {
            ViewData["Categoryid"] = new SelectList(_context.Category,"id","Name");
            return View();
        }
        [Authorize(Roles = "Admin,Seller")]
        // POST: SecondHands/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SecondHandViewModel vm)
        {
            var data = new SecondHand()
            {
                id = gen.SetId(_context),
                Active = true,
                Descripcion = vm.Descripcion,
                Marca = vm.Marca,
                Modelo = vm.Modelo,
                PrecioCompra = vm.PrecioCompra,
                Categoryid = vm.Categoryid,
                SellerId = userManager.GetUserId(HttpContext.User),
                Imagen = uploader.UploadSHPic(vm, webHostEnvironment),
                Posted = DateTime.Now,
                PrecioVenta = sell.SellerPrices(vm.PrecioCompra)
            };
            ViewData["Categoryid"] = new SelectList(_context.Category, "id", "Name",vm.Categoryid);
            sender.SendSecondHandProductCreated(data.SellerId,data);
            _context.Add(data);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin,Seller")]
        // GET: SecondHands/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var secondHand = await _context.SecondHand.FindAsync(id);
            if (secondHand == null)
            {
                return NotFound();
            }
            return View(secondHand);
        }
        [Authorize(Roles = "Admin,Seller")]
        // POST: SecondHands/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, SecondHandViewModel secondHand)
        {
            var data = _context.SecondHand.Find(id);
            data.Modelo = secondHand.Modelo;
            data.Marca = secondHand.Marca;
            data.PrecioCompra = secondHand.PrecioCompra;
            data.PrecioVenta = sell.SellerPrices(secondHand.PrecioCompra);
            data.Imagen = uploader.UploadSHPic(secondHand,webHostEnvironment);
            _context.Update(data);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin,Seller")]
        // GET: SecondHands/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var secondHand = await _context.SecondHand
                .FirstOrDefaultAsync(m => m.id == id);
            if (secondHand == null)
            {
                return NotFound();
            }

            return View(secondHand);
        }
        [Authorize(Roles = "Admin,Seller")]
        // POST: SecondHands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var secondHand = await _context.SecondHand.FindAsync(id);
            _context.SecondHand.Remove(secondHand);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SecondHandExists(string id)
        {
            return _context.SecondHand.Any(e => e.id == id);
        }
    }
}
