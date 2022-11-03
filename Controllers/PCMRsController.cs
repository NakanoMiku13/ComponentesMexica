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
using Microsoft.AspNetCore.Hosting;
using ComponentesMexica.Data.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace ComponentesMexica.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PCMRsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IWebHostEnvironment webHostEnvironment;
        protected ImageUploader uploader = new ImageUploader();
        protected Prices sell = new Prices();
        protected MailSender sender = new MailSender();
        public PCMRsController(ApplicationDbContext context, UserManager<IdentityUser> userManager,IWebHostEnvironment webHost)
        {
            _context = context;
            this.userManager = userManager;
            webHostEnvironment = webHost;
        }
        protected string GetUser()
        {
            return userManager.GetUserId(HttpContext.User);
        }
        [Authorize(Roles = "Admin")]
        // GET: PCMRs
        public async Task<IActionResult> Index()
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entró en Index/PCMRs", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            return View(await _context.PCMR.ToListAsync());
        }
        [Authorize(Roles = "Admin")]
        // GET: PCMRs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entró en Detail/PCMRs", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id == null)
            {
                return NotFound();
            }

            var pCMR = await _context.PCMR
                .FirstOrDefaultAsync(m => m.id == id);
            if (pCMR == null)
            {
                return NotFound();
            }

            return View(pCMR);
        }
        [Authorize(Roles = "Admin")]
        // GET: PCMRs/Create
        public async Task<IActionResult> Create()
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entró en Create/PCMRs", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            ViewData["Mobo"] = new SelectList(_context.Componente.Where(p => p.Active == true && p.Categoryid == 1), "Modelo", "Modelo");
            ViewData["GPU"] = new SelectList(_context.Componente.Where(p => p.Active == true && p.Categoryid == 2), "Modelo", "Modelo");
            ViewData["CPU"] = new SelectList(_context.Componente.Where(p => p.Active == true && p.Categoryid == 3), "Modelo", "Modelo");
            ViewData["RAM"] = new SelectList(_context.Componente.Where(p => p.Active == true && p.Categoryid == 4), "Modelo", "Modelo");
            ViewData["Case"] = new SelectList(_context.Componente.Where(p => p.Active == true && p.Categoryid == 5), "Modelo", "Modelo");
            ViewData["HDD"] = new SelectList(_context.Componente.Where(p => p.Active == true && p.Categoryid == 6), "Modelo", "Modelo");
            ViewData["PSU"] = new SelectList(_context.Componente.Where(p => p.Active == true && p.Categoryid == 7), "Modelo", "Modelo");
            ViewData["Cooler"] = new SelectList(_context.Componente.Where(p => p.Active == true && p.Categoryid == 8), "Modelo", "Modelo");
            return View();
        }
        [Authorize(Roles = "Admin")]
        // POST: PCMRs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PCMRViewModel vm)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario creó PCMR", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            var mob = _context.Componente.FirstOrDefault(p => p.Modelo == vm.Mobo);
            var cpu = _context.Componente.FirstOrDefault(p => p.Modelo == vm.CPU);
            var gpu = _context.Componente.FirstOrDefault(p => p.Modelo == vm.GPU);
            var psu = _context.Componente.FirstOrDefault(p => p.Modelo == vm.PCU);
            var ram = _context.Componente.FirstOrDefault(p => p.Modelo == vm.RAM);
            var hdd = _context.Componente.FirstOrDefault(p => p.Modelo == vm.Almacenamiento);
            var cas = _context.Componente.FirstOrDefault(p => p.Modelo == vm.Case);
            decimal total = mob.PrecioVenta + cpu.PrecioVenta + gpu.PrecioVenta + psu.PrecioVenta + ram.PrecioVenta + hdd.PrecioVenta + cas.PrecioVenta + ram.PrecioVenta;
            if (vm.RAM1 != "No aplica")
            {
                total += ram.PrecioVenta;
            }
            if (vm.RAM2 != "No aplica")
            {
                total += ram.PrecioVenta;
            }
            if(vm.RAM3 != "No aplica")
            {
                total += ram.PrecioVenta;
            }
            if (vm.Cooler != "No aplica")
            {
                var cool = _context.Componente.FirstOrDefault(p => p.Modelo == vm.Cooler);
                total += cool.PrecioVenta;
            }
            var Data = new PCMR()
            {
                Descripcion = vm.Descripcion,
                Active = true,
                Almacenamiento = vm.Almacenamiento.ToUpper(),
                AlmacenamientoSecu=vm.AlmacenamientoSecu.ToUpper(),
                Case = vm.Case.ToUpper(),
                CPU = vm.CPU.ToUpper(),
                PCU = vm.PCU.ToUpper(),
                EmployeeId = userManager.GetUserId(HttpContext.User),
                GPU = vm.GPU.ToUpper(),
                Mobo = vm.Mobo.ToUpper(),
                Nombre = vm.Nombre.ToUpper(),
                Published = DateTime.Now,
                RAM = vm.RAM.ToUpper(),
                RAM1=vm.RAM1.ToUpper(),
                RAM2=vm.RAM2.ToUpper(),
                RAM3=vm.RAM3.ToUpper(),
                SSDM2=vm.SSDM2.ToUpper(),
                Cooler=vm.Cooler.ToUpper(),
                Imagen = uploader.UploadPCMRPic(vm, webHostEnvironment),
                PrecioVenta = total,
                Comision = sell.Com(total),
                Ganancia = total - sell.Com(total)
            };
            _context.Add(Data);
            _context.SaveChanges();
            sender.SendMailPCMRAdded(Data.EmployeeId,Data);
            ViewData["Mobo"] = new SelectList(_context.Componente.Where(p => p.Active == true && p.Categoryid == 1), "Modelo", "Modelo", vm.Mobo);
            ViewData["GPU"] = new SelectList(_context.Componente.Where(p => p.Active == true && p.Categoryid == 2), "Modelo", "Modelo", vm.GPU);
            ViewData["CPU"] = new SelectList(_context.Componente.Where(p => p.Active == true && p.Categoryid == 3), "Modelo", "Modelo", vm.CPU);
            ViewData["RAM"] = new SelectList(_context.Componente.Where(p => p.Active == true && p.Categoryid == 4), "Modelo", "Modelo", vm.RAM);
            ViewData["Case"] = new SelectList(_context.Componente.Where(p => p.Active == true && p.Categoryid == 5), "Modelo", "Modelo", vm.Case);
            ViewData["HDD"] = new SelectList(_context.Componente.Where(p => p.Active == true && p.Categoryid == 6), "Modelo", "Modelo", vm.Almacenamiento);
            ViewData["PSU"] = new SelectList(_context.Componente.Where(p => p.Active == true && p.Categoryid == 7), "Modelo", "Modelo", vm.PCU);
            ViewData["Cooler"] = new SelectList(_context.Componente.Where(p => p.Active == true && p.Categoryid == 8), "Modelo", "Modelo", vm.Cooler);
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        // GET: PCMRs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entró en Edit/PCMRs", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id == null)
            {
                return NotFound();
            }

            var pCMR = await _context.PCMR.FindAsync(id);
            if (pCMR == null)
            {
                return NotFound();
            }
            return View(pCMR);
        }
        [Authorize(Roles = "Admin")]
        // POST: PCMRs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Nombre,Descripcion,CPU,Mobo,GPU,PCU,RAM,Almacenamiento,AlmacenamientoSecu,Case,PrecioVenta,PrecioComision,Ganancia,Comision,EmployeeId,Published,Active,Imagen")] PCMR pCMR)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario editó una PCMR", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id != pCMR.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var userid = GetUser();
                    sender.SendMailPCMREdited(userid,pCMR);
                    _context.Update(pCMR);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PCMRExists(pCMR.id))
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
            return View(pCMR);
        }
        [Authorize(Roles = "Admin")]
        // GET: PCMRs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entró en Delete/PCMRs", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id == null)
            {
                return NotFound();
            }

            var pCMR = await _context.PCMR
                .FirstOrDefaultAsync(m => m.id == id);
            if (pCMR == null)
            {
                return NotFound();
            }

            return View(pCMR);
        }
        [Authorize(Roles = "Admin")]
        // POST: PCMRs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario eliminó PCMR", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            var pCMR = await _context.PCMR.FindAsync(id);
            _context.PCMR.Remove(pCMR);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [Authorize(Roles = "Admin")]
        private bool PCMRExists(int id)
        {
            return _context.PCMR.Any(e => e.id == id);
        }
    }
}
