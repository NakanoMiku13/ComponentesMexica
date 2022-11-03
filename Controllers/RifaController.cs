using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using ComponentesMexica.Data;
using ComponentesMexica.Data.Models;
using ComponentesMexica.Data.Repositories;
using ComponentesMexica.Data.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ComponentesMexica.Controllers
{
    public class RifaController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<IdentityUser> userManager;
        protected GenTicket genTicket = new GenTicket();
        protected GenId gen = new GenId();
        protected MailSender sender = new MailSender();
        public RifaController(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            this.userManager = userManager;
            this.context = context;
        }
        [Authorize]
        public IActionResult Index()
        {
            var data = context.Rifas.FirstOrDefault(p => p.Active == true);
            if (data != null)
            {
                data.Componente = context.Componente.FirstOrDefault(p => p.id == data.Componenteid);
            }
            var x = context.Timer.FirstOrDefault(p => p.id == 1);
            ViewBag.Time = x.Data.Year.ToString() + "/" + x.Data.Month + "/" + x.Data.Day + " 12:00PM";
            return View(data);
        }
        [Authorize(Roles ="Admin")]
        public IActionResult Lista()
        {
            return View(context.Ganadores.ToList());
        }
        [Authorize(Roles ="Admin")]
        public IActionResult Rifas()
        {
            return View(context.Rifas.ToList());
        }
        [Authorize(Roles ="Admin")]
        public IActionResult AddRifa()
        {
            ViewData["Componenteid"] = new SelectList(context.Componente, "id", "Modelo");
            return View();
        }
        [Authorize(Roles ="Admin")]
        [HttpPost]
        public IActionResult AddRifa(Rifas rifa)
        {
            var prod = context.Componente.FirstOrDefault(p=>p.id==rifa.Componenteid);
            var Rifa = context.Rifas.FirstOrDefault(p => p.Active == true);
            if (Rifa != null)
            {
                Rifa.Active = false;
                context.Update(Rifa);
                context.SaveChanges();
            }
            rifa.Active = true;
            rifa.CostoTicket = (((prod.PrecioCompra / rifa.Tickets) + Ganancia(rifa.Tickets)) * Convert.ToDecimal(1.0395)) + 4;
            rifa.id = gen.SetId(context);
            context.Add(rifa);
            context.SaveChanges();
            ViewData["Componenteid"] = new SelectList(context.Componente, "id", "Modelo",rifa.Componenteid);
            return View("Lista");
        }
        protected int Ganancia(int cantidad)
        {
            if (cantidad <= 100)
            {
                return 34;
            }
            else if (cantidad <= 300)
            {
                return 19;
            }
            else
            {
                return 14;
            }
        }
        [Authorize]
        public IActionResult Register()
        {
            var data = context.Rifas.FirstOrDefault(p => p.Active == true);
            if (data != null)
            {
                if (data.Tickets == 0)
                {
                    var Error = new ErrorVM()
                    {
                        DataError = "Ya no quedan tickets disponibles"
                    };
                    return View("Error", Error);
                }
                else
                {
                    ViewBag.total = data.Tickets;
                    ViewBag.costo = data.CostoTicket;
                    return View();
                }
            }
            else
            {
                var Error = new ErrorVM()
                {
                    DataError = "Por el momento no hay rifas disponibles"
                };
                return View("Error", Error);
            }
        }
        [HttpPost]
        public IActionResult Register(TicketViewModel vm)
        {
            var rifa = context.Rifas.FirstOrDefault(p=>p.Active==true);
            if (rifa.Tickets != 0)
            {
                var Error = new ErrorVM()
                {
                    DataError = "Ya no quedan tickets disponibles"
                };
                return View("Error", Error);
            }
            else
            {
                for (int i = 0; i < vm.Cantidad; i++)
                {
                    var registro = new Tickets()
                    {
                        Numero = genTicket.SetTicketNumber(context),
                        Comprado = DateTime.Now,
                        Rifaid = rifa.id,
                        userid = userManager.GetUserId(HttpContext.User),
                        Costo = rifa.CostoTicket
                    };
                    context.Add(registro);
                    context.SaveChanges();
                }
                rifa.Tickets -= vm.Cantidad;
                rifa.Acumulado += (rifa.CostoTicket * vm.Cantidad);
                context.Update(rifa);
                context.SaveChanges();
                var compra = new RifaOrder()
                {
                    id = gen.SetId(context),
                    Acreditado = false,
                    ReferenciaPago = gen.SetId(context),
                    total = (rifa.CostoTicket * vm.Cantidad),
                    userid = userManager.GetUserId(HttpContext.User),
                    Rifaid = rifa.id,
                    CantTickets = vm.Cantidad,
                    Visible = true
                };
                context.Add(compra);
                context.SaveChanges();
                sender.SendRifaBuy(compra, context.Users.Find(userManager.GetUserId(HttpContext.User)));
                return RedirectToAction("Paypal", compra);
            } 
        }
        [Authorize]
        public IActionResult Error(ErrorVM vm)
        {
            return View(vm);
        }
        [Authorize]
        public IActionResult Paypal(RifaOrder order)
        {
            double data = Convert.ToDouble(order.total);
            ViewBag.Total = data.ToString(CultureInfo.CreateSpecificCulture("en-US"));
            return View(order);
        }
    }
}
