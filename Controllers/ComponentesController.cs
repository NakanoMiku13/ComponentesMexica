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
using Microsoft.AspNetCore.Hosting;
using ComponentesMexica.Data.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Runtime.CompilerServices;

namespace ComponentesMexica.Controllers
{
    
    public class ComponentesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment webhost;
        private readonly UserManager<IdentityUser> userManager;
        protected MailSender mailSender = new MailSender();
        protected ImageUploader uploader = new ImageUploader();
        protected Prices sell = new Prices();
        protected LastOne search = new LastOne();
        protected TempData temp = new TempData();
        public ComponentesController(ApplicationDbContext context,IWebHostEnvironment host,UserManager<IdentityUser>user)
        {
            userManager = user;
            _context = context;
            webhost = host;
        }
        protected string GetUser()
        {
            return userManager.GetUserId(HttpContext.User);
        }
        [Authorize(Roles = "Admin")]
        // GET: Componentes
        public async Task<IActionResult> Index()
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entro en Index/Componentes", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            var applicationDbContext = _context.Componente.ToListAsync();
            return View(await applicationDbContext);
        }
        [Authorize(Roles = "Admin")]
        // GET: Componentes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entro en Details/Componentes", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id == null)
            {
                return NotFound();
            }

            var componente = await _context.Componente.FirstOrDefaultAsync(m => m.id == id);
            if (componente == null)
            {
                return NotFound();
            }

            return View(componente);
        }
        [Authorize(Roles = "Admin")]
        // GET: Componentes/Create
        public async Task<IActionResult> Create()
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entro en Create/Componentes", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            ViewData["Categoryid"] = new SelectList(_context.Category, "id", "Name");
            return View();
        }
        [Authorize(Roles = "Admin")]
        // POST: Componentes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ComponenteViewModel vm)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario creó un producto", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            var Prod = new Componente()
            {
                Descripcion = vm.Descripcion,
                Marca = vm.Marca.ToUpper(),
                Modelo = vm.Modelo.ToUpper(),
                Active = true,
                Imagen = uploader.UploadComponentPic(vm, webhost),
                PrecioCompra = vm.PrecioCompra,
                PrecioVenta = sell.SellPrice(vm.PrecioCompra),
                Subido = DateTime.Now,
                Employeeid = GetUser(),
                ComisionPay = sell.Com(vm.PrecioCompra),
                Ganancia = sell.Gana(vm.PrecioCompra),
                Categoryid = vm.Categoryid,
                Capacidad = vm.Capacidad,
                Wattage = vm.Wattage,
                Formato = vm.Formato.ToUpper(),
                Socket = vm.Socket.ToUpper()
            };
            mailSender.SendMailArticleAdded(Prod, Prod.Employeeid, DateTime.Now);
            await _context.AddAsync(Prod);
            await _context.SaveChangesAsync();
            ViewData["Categoryid"] = new SelectList(_context.Category, "id", "id", vm.Categoryid);
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ActualizarEstadoRevision(int id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario Actualizó estado a revisión", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            var data = await _context.Componente.FindAsync(id);
            data.Revision = true;
            _context.Update(data);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ActualizarEstadoActivo(int id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario actualizó estado a Activo", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            var data = await _context.Componente.FindAsync(id);
            data.Active = true;
            _context.Update(data);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ActualizarEstadoDesactivar(int id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario actualizó estado a Descativo", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            var data = await _context.Componente.FindAsync(id);
            data.Active = false;
            _context.Update(data);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        // GET: Componentes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entro en Edit/Componentes", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id == null)
            {
                return NotFound();
            }

            var componente = await _context.Componente.FindAsync(id);
            if (componente == null)
            {
                return NotFound();
            }
            ViewData["Categoryid"] = new SelectList(_context.Category, "id", "Name", componente.Categoryid);
            temp.TempDataComponent(_context,componente);
            return View(componente);
        }
        [Authorize(Roles = "Admin")]
        // POST: Componentes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Componente componente)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario editó componente", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id != componente.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var last = await _context.tempComponents.FirstOrDefaultAsync(p=>p.CompID==id);
                    _context.Update(componente);
                    componente.PrecioVenta = sell.SellPrice(componente.PrecioCompra);
                    componente.Ganancia = sell.Gana(componente.PrecioCompra);
                    componente.ComisionPay = sell.Com(componente.PrecioCompra);
                    componente.Subido = DateTime.Now;
                    var data = new Edited()
                    {
                        Deleted = false,
                        Componenteid = componente.id,
                        Employeeid = GetUser(),
                        EditedTime = DateTime.Now,
                        Edit =
                        "Editado\n"+
                        "Anterior:\n"+
                        last.Marca+"\n"+
                        last.Modelo+"\n"+
                        last.PrecioCompra.ToString()+"\n"+
                        last.Imagen+"\n"+
                        "Nuevo:\n"+
                        componente.Marca+"\n"+
                        componente.Modelo+"\n"+
                        componente.PrecioCompra.ToString()+"\n"+
                        componente.Imagen
                        
                    };
                    _context.Add(data);
                    await _context.SaveChangesAsync();
                    temp.DeleteTempData(id,_context);
                    _context.ChangeTracker.AcceptAllChanges();
                    mailSender.SendMailArticleEdited(componente, data.Employeeid, data.EditedTime, data.Edit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComponenteExists(componente.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Categoryid"] = new SelectList(_context.Category, "id", "id", componente.Categoryid);
            return View(componente);
        }
        [Authorize(Roles = "Admin")]
        // GET: Componentes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entro en Delete/Componentes", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id == null)
            {
                return NotFound();
            }

            var componente = await _context.Componente
                .FirstOrDefaultAsync(m => m.id == id);
            if (componente == null)
            {
                return NotFound();
            }

            return View(componente);
        }
        [Authorize(Roles = "Admin")]
        // POST: Componentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario eliminó articulo", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            var componente = await _context.Componente.FindAsync(id);
            var Edit = new Edited()
            {
                Edit = "Eliminado\n"+componente.Marca+"\n"+componente.Modelo + "\n" +componente.PrecioCompra.ToString() + "\n" +componente.Subido.ToString() + "\n" +componente.Imagen + "\n" +componente.id.ToString(),
                EditedTime=DateTime.Now,
                Deleted=true,
                Componenteid=id,
                Employeeid=GetUser(),                
            };
            _context.Add(Edit);
            var data = await _context.Componente.FindAsync(id);
            mailSender.SendMailArticleDeleted(data,GetUser(),DateTime.Now);
            await _context.SaveChangesAsync();
            _context.Componente.Remove(componente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [Authorize(Roles = "Admin")]
        private bool ComponenteExists(int id)
        {
            return _context.Componente.Any(e => e.id == id);
        }
    }
}
