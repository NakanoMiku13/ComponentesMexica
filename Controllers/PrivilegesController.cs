using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ComponentesMexica.Data;
using ComponentesMexica.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using ComponentesMexica.Data.Repositories;

namespace ComponentesMexica.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PrivilegesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> userManager;
        public PrivilegesController(ApplicationDbContext context,UserManager<IdentityUser>user)
        {
            _context = context;
            userManager = user;
        }
        protected string GetUser()
        {
            return userManager.GetUserId(HttpContext.User);
        }
        [Authorize(Roles = "Admin")]
        // GET: Privileges
        public async Task<IActionResult> Index()
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entró en Index/Privileges", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            return View(await _context.Privilege.ToListAsync());
        }
        [Authorize(Roles = "Admin")]
        // GET: Privileges/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entró en Details/Privileges", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id == null)
            {
                return NotFound();
            }

            var privilege = await _context.Privilege
                .FirstOrDefaultAsync(m => m.id == id);
            if (privilege == null)
            {
                return NotFound();
            }

            return View(privilege);
        }
        [Authorize(Roles = "Admin")]
        // GET: Privileges/Create
        public async Task<IActionResult> Create()
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entró en Create/Privileges", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            return View();
        }
        [Authorize(Roles = "Admin")]
        // POST: Privileges/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Name")] Privilege privilege)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario creó un privilegio", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (ModelState.IsValid)
            {
                var x = new IdentityRole()
                {
                    Name = privilege.Name,
                    NormalizedName = privilege.Name.ToUpper()
                };
                await _context.AddAsync(x);
                await _context.AddAsync(privilege);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(privilege);
        }
        [Authorize(Roles = "Admin")]
        // GET: Privileges/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entró en Edit/Privileges", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id == null)
            {
                return NotFound();
            }

            var privilege = await _context.Privilege.FindAsync(id);
            if (privilege == null)
            {
                return NotFound();
            }
            return View(privilege);
        }
        [Authorize(Roles = "Admin")]
        // POST: Privileges/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Name")] Privilege privilege)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario editó un privilegio", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id != privilege.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(privilege);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrivilegeExists(privilege.id))
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
            return View(privilege);
        }
        [Authorize(Roles = "Admin")]
        // GET: Privileges/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entró en Delete/Privileges", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id == null)
            {
                return NotFound();
            }

            var privilege = await _context.Privilege
                .FirstOrDefaultAsync(m => m.id == id);
            if (privilege == null)
            {
                return NotFound();
            }

            return View(privilege);
        }
        [Authorize(Roles = "Admin")]
        // POST: Privileges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario eliminó privilegio", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            var privilege = await _context.Privilege.FindAsync(id);
            _context.Privilege.Remove(privilege);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [Authorize(Roles = "Admin")]
        private bool PrivilegeExists(int id)
        {
            return _context.Privilege.Any(e => e.id == id);
        }
    }
}
