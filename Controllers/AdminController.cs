using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComponentesMexica.Data;
using ComponentesMexica.Data.Models;
using ComponentesMexica.Data.Repositories;
using ComponentesMexica.Data.ViewModels;
using DocumentFormat.OpenXml.Presentation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComponentesMexica.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly BackUpContext back;
        private readonly UserManager<IdentityUser> userManager;
        protected PreLoadEntityData entityData = new PreLoadEntityData();
        protected BackUp backUp = new BackUp();
        protected PreLoadCategories categories = new PreLoadCategories();
        protected PreloadED d = new PreloadED();
        protected GenId gen = new GenId();
        protected SW setWinner = new SW();
        protected MailSender sender = new MailSender();
        protected GenReport report = new GenReport();
        protected string GetUser()
        {
            return userManager.GetUserId(HttpContext.User);
        }
        public AdminController(ApplicationDbContext ctx,BackUpContext context, UserManager<IdentityUser> userManager)
        {
            this.context = ctx;
            back = context;
            this.userManager = userManager;

        }
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> DownloadLog()
        {
            var log = new Logs() { id = gen.SetId(context), log = "Descargarndo Log", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            sender.SendPWDLog(context);
            return RedirectToAction("SetPWD");
        }
        [Authorize(Roles ="Admin")]
        public IActionResult SetPWD()
        {
            ViewBag.Data = false;
            return View();
        }
        
        [Authorize(Roles ="Admin"),HttpPost]
        public async Task<IActionResult> SetPWD(PWDLog log)
        {
            var x = await context.pWDLogs.FirstOrDefaultAsync(p=>p.Pwd==log.Pwd);
            if (x != null)
            {
                if (x.Date.Day == DateTime.Now.Day)
                {
                    if (x.Valid)
                    {
                        var user = await context.Users.FindAsync(GetUser());
                        if (user != null)
                        {
                            var Privilege = await context.Roles.FirstOrDefaultAsync(p => p.Name == "Admin");
                            var Roles = await context.UserRoles.FirstOrDefaultAsync(p => p.UserId == GetUser() && p.RoleId==Privilege.Id);
                            if (Roles != null)
                            {
                                ViewBag.Data = true;
                                x.Valid = false;
                                context.pWDLogs.Update(x);
                                await context.SaveChangesAsync();
                                new GenReport().SetLog(context);
                                return View();
                            }
                            else
                            {
                                return View("Error", new ErrorVM() { DataError="Contraseña Erronea"});
                            }
                        }
                        else
                        {
                            return View("Error", new ErrorVM() { DataError = "Contraseña Erronea" });
                        }
                    }
                    else
                    {
                        return View("Error", new ErrorVM() { DataError = "Contraseña Erronea" });
                    }
                }
                else
                {
                    return View("Error", new ErrorVM() { DataError = "Contraseña Erronea" });
                }
            }
            else
            {
                return View("Error", new ErrorVM() { DataError = "Contraseña Erronea" });
            }
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            var log = new Logs() { id = gen.SetId(context), log = "Usuario entro en Index/Admin", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            return View();
        }
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> Ganadores()
        {
            var log = new Logs() { id = gen.SetId(context), log = "Usuario entro en Ganadores/Admin", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            return View(await context.Ganadores.ToListAsync());
        }
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> SetWinner()
        {
            var log = new Logs() { id = gen.SetId(context), log = "Ganador de rifa ha sido seleccionado", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var x = await context.Rifas.FirstOrDefaultAsync(p=>p.Active==true);
            if (x == null)
            {
                var Error = new ErrorVM()
                {
                    DataError="No hay rifas activas"
                };
                return RedirectToAction("Error", Error);
            }
            else
            {
                if (x.Tickets != 0)
                {
                    var Error = new ErrorVM()
                    {
                        DataError = "No se han vendido todos los tickets"
                    };
                    return RedirectToAction("Error", Error);
                }
                else
                {
                    setWinner.SetWinner(context);
                    return RedirectToAction("Index");
                }
            }
        }
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> AcceptBuyTicket(string userid, string refpago)
        {
            var log = new Logs() { id = gen.SetId(context), log = "Compra de ticket aceptada", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var data = await context.RifaOrders.FirstOrDefaultAsync(p => p.userid == userid && p.ReferenciaPago == refpago);
            data.Acreditado = true;
            context.Update(data);
            await context.SaveChangesAsync();
            sender.SendConfirmBuyTicket(data, await context.Users.FindAsync(data.userid));
            return RedirectToAction("TicketComprados");
        }
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> DenyTicketBuy(string userid,string refpago)
        {
            var log = new Logs() { id = gen.SetId(context), log = "Compra de ticket denegada", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var data = await context.RifaOrders.FirstOrDefaultAsync(p => p.userid == userid && p.ReferenciaPago == refpago);
            var dataTicket = context.Tickets.Where(p => p.userid == userid);
            sender.SendDenyBuyTicket(await context.Users.FindAsync(userid), data);
            context.RemoveRange(dataTicket);
            data.ReferenciaPago = "Cancelado";
            data.Rifaid = "Nulo";
            data.Visible = true;
            context.Update(data);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> TicketComprados()
        {
            var log = new Logs() { id = gen.SetId(context), log = "Usuario entro en TicketsComprados/Admin", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var rifa = await context.Rifas.FirstOrDefaultAsync(p => p.Active == true);
            if (rifa == null)
            {
                return View("Error", new ErrorVM() { DataError = "No hay rifas activas" });
            }
            return View(context.RifaOrders.ToList().Where(p => p.Rifaid == rifa.id));
        }
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> FinishActual()
        {
            var log = new Logs() { id = gen.SetId(context), log = "Usuario Finalizo rifa", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var data = await context.Rifas.FirstOrDefaultAsync(p => p.Active == true);
            if (data == null)
            {
                return View("Error", new ErrorVM() { DataError = "No hay rifas activas" });
            }
            else
            {
                if (data.Tickets == 0)
                {
                    var order = context.RifaOrders.ToList().Where(P => P.id == data.id);
                    foreach (var i in order)
                    {
                        i.Visible = false;
                        context.Update(i);
                        await context.SaveChangesAsync();
                    }
                    data.Active = false;
                    context.Update(data);
                    await context.SaveChangesAsync();
                }
                else
                {
                    return RedirectToAction("Error", new ErrorVM() { DataError = "Aun quedan tickets por vender" });
                }
                return RedirectToAction("Index");
            }
        }
        [Authorize(Roles = "Admin, Manager")]
        public async Task<IActionResult> LoadData()
        {
            var log = new Logs() { id = gen.SetId(context), log = "Usuario precargo datos de las entidades", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            entityData.Load(context);
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin, Manager")]
        public async Task<IActionResult> BackUp()
        {
            var log = new Logs() { id = gen.SetId(context), log = "Usuario Generó un back up de la base de datos", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            backUp.Data(back, context);
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin, Manager")]
        public async Task<IActionResult> PreLoadCat()
        {
            var log = new Logs() { id = gen.SetId(context), log = "Usuario precargo las categorias", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var data = await context.Category.FirstOrDefaultAsync(p => p.Name == "Mobo");
            if (data == null)
            {
                categories.PreLoadData(context);
                return RedirectToAction("Index");
            }
            else
            {
                
                var error = new ErrorVM()
                {
                    DataError = "Datos ya precargados"
                };
                return RedirectToAction("Error",error);
            }
            
        }
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> PreLoadRoles()
        {
            var log = new Logs() { id = gen.SetId(context), log = "Usuario entro en Ganadores/Admin", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var data = await context.Privilege.FirstOrDefaultAsync(p=>p.Name=="Manager");
            if(data == null)
            {
                d.Load(context);
                return RedirectToAction("Index");
            }
            else
            {
                var vm = new ErrorVM()
                {
                    DataError = "Datos ya precargados"
                };
                return RedirectToAction("Error", vm);
            }
        }
        public async Task<IActionResult> Error(ErrorVM data)
        {
            var log = new Logs() { id = gen.SetId(context), log = "Excepción data "+data.DataError, Logged = DateTime.Now, userid = "null" };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            return View(data);
        }
    }
}
