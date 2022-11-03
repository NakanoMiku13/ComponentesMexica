using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using ComponentesMexica.Data;
using ComponentesMexica.Data.Models;
using ComponentesMexica.Data.Repositories;
using ComponentesMexica.Data.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComponentesMexica.Controllers
{
    [Authorize]
    public class ReportController : Controller
    {
        private readonly ApplicationDbContext context;
        protected GenId gen = new GenId();
        protected ImageUploader uploader = new ImageUploader();
        protected MailSender sender = new MailSender(); 
        private readonly UserManager<IdentityUser> userManager;
        private readonly IWebHostEnvironment webHostEnvironment;
        protected string GetUser()
        {
            return userManager.GetUserId(HttpContext.User);
        }
        public ReportController(ApplicationDbContext context, UserManager<IdentityUser> userManager, IWebHostEnvironment webHostEnvironment)
        {
            this.context = context;
            this.webHostEnvironment = webHostEnvironment;
            this.userManager = userManager;
        }
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> Index()
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró en Index/Report", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var data = context.Reportes.ToList().OrderBy(p=>p.Report);
            return View(data);
        }
        [Authorize]
        public async Task<IActionResult> Reportar(string id, string Seller)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró en Reportar/Report", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var seler = await context.Vendedor.FirstOrDefaultAsync(p => p.userid == Seller);
            var prod = await context.SecondHand.FirstOrDefaultAsync(p => p.id == id && p.SellerId == Seller);
            ViewBag.Producto = prod;
            ViewBag.Vendedor = seler;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Reportar(ReporteViewModel vm)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario reportó un vendedor", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var order = await context.Orders.FirstOrDefaultAsync(p => p.RefPago == vm.ReferenciaPago);
            var userid = GetUser();
            var user = await context.Users.FindAsync(userid);
            var data = new Reporte()
            {
                id = gen.SetId(context),
                ReporteData = vm.ReporteData,
                Nombre = user.UserName,
                userid = userid,
                ReferenciaPago = vm.ReferenciaPago,
                Report = DateTime.Now,
                Orderid = order.id.ToString(),
                Referencia = gen.SetId(context),
                Sellerid = vm.Sellerid,
                UserMail = user.Email,
                Evidencia1 = uploader.UploadEvidence1(vm, webHostEnvironment),
                Evidencia2 = uploader.UploadEvidence2(vm, webHostEnvironment),
                Evidencia3 = uploader.UploadEvidence3(vm, webHostEnvironment)
            };
            var rp = context.Reportes.Where(p => p.Sellerid == vm.Sellerid);
            int cuenta;
            if (rp == null)
            {
                cuenta = 1;
            }
            else
            {
                cuenta = rp.Count();
            }
            var x = await context.Vendedor.FirstOrDefaultAsync(p => p.id == data.Sellerid);
            var y = await context.Users.FindAsync(x.userid);
            var rps = await context.RerporteSeller.FirstOrDefaultAsync(p=>p.Sellerid==x.id && p.useridSeller==y.Id);
            if (rps == null)
            {
                var reportS = new SellerReports()
                {
                    reportid = data.id,
                    Cuenta = cuenta,
                    id = gen.SetId(context),
                    Sellerid = data.Sellerid,
                    useridSeller = y.Id
                };
                await context.AddAsync(reportS);
                await context.SaveChangesAsync();
            }
            else
            {
                rps.Cuenta++;
                context.Update(rps);
                await context.SaveChangesAsync();
                if (rps.Cuenta >= 3)
                {
                    x.Active = false;
                    context.Update(x);
                    await context.SaveChangesAsync();
                    sender.SendInform(x);
                }
            }
            x.Active = false;
            var sellermail = await context.Users.FirstOrDefaultAsync(p=>p.Id==x.userid);
            await context.AddAsync(data);
            context.Update(x);
            await context.SaveChangesAsync();
            sender.SendMailAdminReport(userid,data,sellermail.Email);
            sender.SendInform(x);
            var datas = new ErrorVM()
            {
                DataError = data.id
            };
            return RedirectToAction("Complete",datas);
        }
        public async Task<IActionResult> Complete(ErrorVM id)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario completó reporte", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            ViewBag.data = id.DataError;
            return View();
        }
    }
}
