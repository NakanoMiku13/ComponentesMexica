using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ComponentesMexica.Data;
using ComponentesMexica.Data.Models;
using ComponentesMexica.Data.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace ComponentesMexica.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PromoCodesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> userManager;
        protected MailSender sender = new MailSender();
        protected string GetUser()
        {
            return userManager.GetUserId(HttpContext.User);
        }
        public PromoCodesController(ApplicationDbContext context,UserManager<IdentityUser> user)
        {
            _context = context;
            userManager = user;
        }
        [Authorize(Roles = "Admin")]
        // GET: PromoCodes
        public async Task<IActionResult> Index()
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entró en Index/PromoCodes", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            return View(await _context.PromoCodes.ToListAsync());
        }
        [Authorize(Roles = "Admin")]
        // GET: PromoCodes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entró en Details/PromoCodes", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id == null)
            {
                return NotFound();
            }

            var promoCodes = await _context.PromoCodes
                .FirstOrDefaultAsync(m => m.id == id);
            if (promoCodes == null)
            {
                return NotFound();
            }

            return View(promoCodes);
        }
        [Authorize(Roles = "Admin")]
        // GET: PromoCodes/Create
        public async Task<IActionResult> Create()
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entró en Create/PromoCodes", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            return View();
        }
        [Authorize(Roles = "Admin")]
        // POST: PromoCodes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Code,Desc,EmployeeID,Active,Published")] PromoCodes promoCodes)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario creó un código", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (ModelState.IsValid)
            {
                var userid = GetUser();
                sender.SendMailPromoCreated(userid,promoCodes);
                promoCodes.Published = DateTime.Now;
                promoCodes.EmployeeID = userid;
                promoCodes.Active = true;
                await _context.AddAsync(promoCodes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(promoCodes);
        }
        [Authorize(Roles = "Admin")]
        // GET: PromoCodes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entró en Edit/PromoCodes", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id == null)
            {
                return NotFound();
            }

            var promoCodes = await _context.PromoCodes.FindAsync(id);
            if (promoCodes == null)
            {
                return NotFound();
            }
            return View(promoCodes);
        }
        [Authorize(Roles = "Admin")]
        // POST: PromoCodes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Code,Desc,EmployeeID,Active,Published")] PromoCodes promoCodes)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario editó un código", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id != promoCodes.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(promoCodes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PromoCodesExists(promoCodes.id))
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
            return View(promoCodes);
        }
        [Authorize(Roles = "Admin")]
        // GET: PromoCodes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entró en Delete/PromoCodes", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id == null)
            {
                return NotFound();
            }

            var promoCodes = await _context.PromoCodes
                .FirstOrDefaultAsync(m => m.id == id);
            if (promoCodes == null)
            {
                return NotFound();
            }

            return View(promoCodes);
        }
        [Authorize(Roles = "Admin")]
        // POST: PromoCodes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario eliminó código", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            var promoCodes = await _context.PromoCodes.FindAsync(id);
            _context.PromoCodes.Remove(promoCodes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [Authorize(Roles = "Admin")]
        private bool PromoCodesExists(int id)
        {
            return _context.PromoCodes.Any(e => e.id == id);
        }
    }
}
