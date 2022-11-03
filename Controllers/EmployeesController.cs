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
using ComponentesMexica.Data.ViewModels;
using Microsoft.AspNetCore.Hosting;
using ComponentesMexica.Data.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace ComponentesMexica.Controllers
{
    [Authorize(Roles = "Admin")]
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly UserManager<IdentityUser> userManager;
        protected ImageUploader upload = new ImageUploader();
        public EmployeesController(ApplicationDbContext context, IWebHostEnvironment host,UserManager<IdentityUser>user)
        {
            _context = context;
            webHostEnvironment = host;
            userManager = user;
        }
        protected string GetUser()
        {
            return userManager.GetUserId(HttpContext.User);
        }
        [Authorize(Roles = "Admin")]
        // GET: Employees
        public async Task<IActionResult> Index()
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entró en Index/Employee", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            return View(await _context.Employee.ToListAsync());
        }
        [Authorize(Roles = "Admin")]
        // GET: Employees/Details/5
        public async Task<IActionResult> Details(string id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entró en Details/Employee", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .Include(e => e.Privilege)
                .FirstOrDefaultAsync(m => m.id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }
        [Authorize(Roles = "Admin")]
        // GET: Employees/Create
        public async Task<IActionResult> Create()
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entró en Create/Employee", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            ViewData["Privilegeid"] = new SelectList(_context.Privilege, "id", "Name");
            return View();
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddRole(Employee vm)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario agregó un rol", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            var user = await _context.Users.FindAsync(vm.id);
            var RoleName = _context.Privilege.FirstOrDefault(p => p.id == vm.Privilegeid);
            var Role = _context.Roles.FirstOrDefault(p => p.Name == RoleName.Name);
            await userManager.AddToRoleAsync(user,Role.Name);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeViewModel vm)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario creó un empleado", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            var User = _context.Users.FirstOrDefault(p => p.Email == vm.Mail);
            var RoleName = _context.Privilege.FirstOrDefault(p => p.id == vm.Privilegeid);
            var Role = _context.Roles.FirstOrDefault(p => p.Name == RoleName.Name);
            var z = new IdentityUserRole<string>()
            {
                RoleId = Role.Id,
                UserId = User.Id
            };
            var Employee = new Employee()
            {
                id = User.Id,
                Nombre = vm.Nombre,
                Apellidos = vm.Apellidos,
                Activo = vm.Activo,
                HireDate = DateTime.Now,
                INE = vm.INE,
                Mail = vm.Mail,
                Numero = vm.Numero,
                Privilegeid = vm.Privilegeid,
                Imagen = upload.UploadEmployeePic(vm, webHostEnvironment)
            };
            _context.Add(Employee);
            _context.Add(z);
            _context.SaveChanges();
            ViewData["Privilegeid"] = new SelectList(_context.Privilege, "id", "id", vm.Privilegeid);
            return RedirectToAction("AddRole",Employee);
        }
        [Authorize(Roles = "Admin")]
        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entró en Edit/Employee", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["Privilegeid"] = new SelectList(_context.Privilege, "id", "id", employee.Privilegeid);
            return View(employee);
        }
        [Authorize(Roles = "Admin")]
        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("id,Mail,Nombre,Apellidos,INE,Numero,Privilegeid,Activo,HireDate,Imagen")] Employee employee)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario editó un empleado", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id != employee.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.id))
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
            ViewData["Privilegeid"] = new SelectList(_context.Privilege, "id", "id", employee.Privilegeid);
            return View(employee);
        }
        [Authorize(Roles = "Admin")]
        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario entró en Delete/Employee", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .Include(e => e.Privilege)
                .FirstOrDefaultAsync(m => m.id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }
        [Authorize(Roles = "Admin")]
        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var log = new Logs() { id = new GenId().SetId(_context), log = "Usuario aceptó delete", Logged = DateTime.Now, userid = GetUser() };
            await _context.AddAsync(log);
            await _context.SaveChangesAsync();
            var employee = await _context.Employee.FindAsync(id);
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [Authorize(Roles = "Admin")]
        private bool EmployeeExists(string id)
        {
            return _context.Employee.Any(e => e.id == id);
        }
    }
}
