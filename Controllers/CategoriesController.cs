using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ComponentesMexica.Data;
using ComponentesMexica.Data.Models;
using Microsoft.AspNetCore.Authorization;
using ComponentesMexica.Data.Repositories;
using Microsoft.AspNetCore.Identity;

namespace ComponentesMexica.Controllers
{
    [Authorize(Roles ="Admin")]
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> userManager;
        public CategoriesController(ApplicationDbContext context,UserManager<IdentityUser>userManager)
        {
            _context = context;
            this.userManager = userManager;
        }
        protected string GetUser()
        {
            return userManager.GetUserId(HttpContext.User);
        }
        [Authorize(Roles = "Admin")]
        // GET: Categories
        public async Task<IActionResult> Index()
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entro en Index/Categorias", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            return View(await _context.Category.ToListAsync());
        }
        [Authorize(Roles = "Admin")]
        // GET: Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entro en Details/Categorias", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category
                .FirstOrDefaultAsync(m => m.id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }
        [Authorize(Roles = "Admin")]
        // GET: Categories/Create
        public async Task<IActionResult> Create()
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entro en Create/Categorias", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Name")] Category category)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario creó una categoria", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (ModelState.IsValid)
            {
                await _context.AddAsync(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
        [Authorize(Roles = "Admin")]
        // GET: Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entro en Edit/Categorias", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [Authorize(Roles = "Admin")]

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Name")] Category category)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario editó una categoria", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id != category.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.id))
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
            return View(category);
        }
        [Authorize(Roles = "Admin")]
        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entro en Delete/Categorias", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category
                .FirstOrDefaultAsync(m => m.id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }
        [Authorize(Roles = "Admin")]
        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario Confirmó delete", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            var category = await _context.Category.FindAsync(id);
            _context.Category.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [Authorize(Roles = "Admin")]
        private bool CategoryExists(int id)
        {
            return _context.Category.Any(e => e.id == id);
        }
    }
}
