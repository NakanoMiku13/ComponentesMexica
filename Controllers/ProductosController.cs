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
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace ComponentesMexica.Controllers
{
    [Authorize]
    public class ProductosController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<IdentityUser> userManager;
        public ProductosController(ApplicationDbContext context,UserManager<IdentityUser>User)
        {
            this.context = context;
            userManager = User;
        }
        protected string GetUser()
        {
            return userManager.GetUserId(HttpContext.User);
        }
        public async Task<IActionResult> Index()
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró en Index/Productos", Logged = DateTime.Now, userid = null };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            return View();
        }
        [Authorize]
        public async Task<IActionResult> AddComent(int id)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró en AddComment/Productos", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var data = await context.Componente.FindAsync(id);
            data.Calificacion++;
            context.Update(data);
            await context.SaveChangesAsync();
            return RedirectToAction("Tlatelolco");
        }
        public async Task<IActionResult> Privacy()
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró en Privacy/Productos", Logged = DateTime.Now, userid = null };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            return View();
        }
        public async Task<IActionResult> Tlatelolco(string category,string Formato)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró en Tlatelolco/Productos", Logged = DateTime.Now, userid = null };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var categoryid = await context.Category.FirstOrDefaultAsync(p => p.Name == category);
            if (string.IsNullOrEmpty(category))
            {
                ViewBag.Pieza = await context.Componente.ToListAsync();
            }
            else
            {
                if (!string.IsNullOrEmpty(Formato))
                {
                    ViewBag.Pieza = context.Componente.ToList().Where(p=>p.Categoryid==categoryid.id && p.Formato==Formato);
                }
                else
                {
                    ViewBag.Pieza = context.Componente.ToList().Where(p => p.Categoryid == categoryid.id);
                }
                ViewBag.Cat = categoryid.Name;
            }
            return View();
        }
        public async Task<IActionResult> Dioses()
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró en Dioses/Productos", Logged = DateTime.Now, userid = null };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var data = await context.PCMR.ToListAsync();
            return View(data);
        }
        [Authorize]
        public async Task<IActionResult> Info(int id)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró en Detail/Productos", Logged = DateTime.Now, userid = GetUser()};
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var data = context.PCMR.Find(id);
            int ContRam=1;
            ViewBag.RAM =  await context.Componente.FirstOrDefaultAsync(p=>p.Modelo==data.RAM);
            if (data.RAM1 != "No aplica") ContRam++;
            if (data.RAM2 != "No aplica") ContRam++;
            if (data.RAM3 != "No aplica") ContRam++;
            ViewBag.RAMTotal = ContRam;
            ViewBag.M2 = await context.Componente.FirstOrDefaultAsync(p => p.Modelo == data.SSDM2);
            ViewBag.Case = await context.Componente.FirstOrDefaultAsync(p => p.Modelo == data.Case); 
            ViewBag.CPU =  await context.Componente.FirstOrDefaultAsync(p => p.Modelo == data.CPU); 
            ViewBag.GPU =  await context.Componente.FirstOrDefaultAsync(p => p.Modelo == data.GPU);
            ViewBag.HDD =  await context.Componente.FirstOrDefaultAsync(p => p.Modelo == data.Almacenamiento) ;
            ViewBag.PSU =  await context.Componente.FirstOrDefaultAsync(p => p.Modelo == data.PCU) ;
            ViewBag.Mobo = await context.Componente.FirstOrDefaultAsync(p => p.Modelo == data.Mobo) ;
            ViewBag.HDD2 = await context.Componente.FirstOrDefaultAsync(p => p.Modelo == data.AlmacenamientoSecu) ;
            return View(data);
        }
        public async Task<IActionResult> Mictlan(string Category)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró en Mictlan/Productos", Logged = DateTime.Now, userid = null };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            if (string.IsNullOrEmpty(Category))
            {
                var data = await context.SecondHand.ToListAsync();
                return View(data);
            }
            else
            {
                var catid = await context.Category.FirstOrDefaultAsync(p=>p.Name==Category);
                var data = context.SecondHand.ToList().Where(p=>p.Categoryid==catid.id).OrderBy(P=>P.Calificacion);
                return View(data);
            }
        }
        [Authorize]
        public async Task<IActionResult> Recomendar(string id, string Seller)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario recomendó un producto", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var data = await context.SecondHand.FirstOrDefaultAsync(p => p.id == id && p.SellerId==Seller);
            var seller = await context.Vendedor.FirstOrDefaultAsync(p => p.userid == Seller);
            if (data == null || seller == null || (seller == null && data == null))
            {
                var vm = new ErrorVM()
                {
                    DataError = "Producto o vendedor no encontrado"
                };
                return RedirectToAction("Error", vm);
            }
            data.Calificacion++;
            seller.Calificacion++;
            context.Update(seller);
            context.Update(data);
            await context.SaveChangesAsync();
            return RedirectToAction("Mictlan");
        }
        [Authorize]
        public async Task<IActionResult> InfoP(string id,string Seller)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró en InfoP/Productos", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var prod = await context.SecondHand.FirstOrDefaultAsync(p => p.id == id && p.SellerId == Seller);
            var seller = await context.Vendedor.FirstOrDefaultAsync(p => p.userid == Seller);
            if (prod == null || seller == null || (seller==null && prod==null))
            {
                var vm = new ErrorVM()
                {
                    DataError="Producto o vendedor no encontrado"
                };
                return RedirectToAction("Error",vm);
            }
            
            var data = new SHSViewModel()
            {
                sh=prod,
                Vd=seller
            };
            return View(data);
        }
        public async Task<IActionResult> Error(ErrorVM vm)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Se detectó un error "+vm.DataError, Logged = DateTime.Now, userid = null };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            return View(vm);
        }
    }
}
