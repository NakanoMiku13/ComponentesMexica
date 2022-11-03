using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ComponentesMexica.Data;
using ComponentesMexica.Data.Models;
using ComponentesMexica.Data.Repositories;
using ComponentesMexica.Data.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MercadoPagoCore;
using MercadoPagoCore.Resources;
using MercadoPagoCore.DataStructures.Preference;
using MercadoPagoCore.Common;

namespace ComponentesMexica.Controllers
{
    public class PaymethodController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<IdentityUser> userManager;
        protected void MercPago(List<OrderDetail> Details)
        {
            MercadoPagoSDK.AccessToken = "TEST-1439335248339872-080118-6d06b587b4f6e5dbcb458a5a9a558a18-286635432";
            Preference preference = new Preference();
            foreach (var i in Details)
            {
                if (i.PCid != 0)
                {
                   var item = context.PCMR.FirstOrDefault(p=>p.id==i.PCid);
                   preference.Items.Add(
                        new MercadoPagoCore.DataStructures.Preference.Item()
                        {
                            Title = item.Nombre,
                            Description = item.Descripcion,
                            Quantity = i.Cantidad,
                            UnitPrice = item.PrecioVenta
                        }
                   );
                }
                else if (i.Compid != 0)
                {
                    var item = context.Componente.FirstOrDefault(p => p.id == i.Compid);
                    preference.Items.Add(
                        new MercadoPagoCore.DataStructures.Preference.Item()
                        {
                            Title = item.Modelo,
                            Description = item.Descripcion,
                            Quantity = i.Cantidad,
                            UnitPrice = item.PrecioVenta
                        }
                    );
                }
                else if (i.SHid != null)
                {
                    var item = context.SecondHand.FirstOrDefault(p => p.id == i.SHid);
                    preference.Items.Add(
                        new MercadoPagoCore.DataStructures.Preference.Item()
                        {
                            Title = item.Modelo,
                            Description = item.Descripcion,
                            Quantity = i.Cantidad,
                            UnitPrice = item.PrecioVenta
                        }
                    );
                }
                else if (i.Sofid != 0)
                {
                    var item = context.Softwares.FirstOrDefault(p => p.id == i.Sofid);
                    preference.Items.Add(
                        new MercadoPagoCore.DataStructures.Preference.Item()
                        {
                            Title = item.Nombre,
                            Description = item.Nombre,
                            Quantity = i.Cantidad,
                            UnitPrice = item.Precio
                        }
                    );
                }
            }
            preference.BackUrls = new BackUrls()
            {
                Success = "https://www.tu-sitio/success",
                Failure = "http://www.tu-sitio/failure",
                Pending = "http://www.tu-sitio/pendings"
            };
            preference.AutoReturn = AutoReturnType.approved;
            preference.Save();
        }
        public PaymethodController(ApplicationDbContext context,UserManager<IdentityUser>user)
        {
            this.context = context;
            userManager = user;
        }
        protected string GetUser()
        {
            return userManager.GetUserId(HttpContext.User);
        }
        [Authorize]
        public async Task<IActionResult> RedirectPay(PaymethodViewModel vm)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario fué redireccionado a un metodo de pago", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var data = context.Orders.FirstOrDefault(p=>p.RefPago==vm.Refe);
            if (vm.PayMethod == "Paypal")
            {
                return RedirectToAction("Paypal",data);
            }
            else if (vm.PayMethod == "MercadoPago")
            {
                return RedirectToAction("MercadoPago",data);
            }
            else if(vm.PayMethod=="Deposito")
            {
                return RedirectToAction("Deposito",data);
            }
            return RedirectToAction("Error",new ErrorVM() { DataError="Metodo de pago no valido o error en servidor"});
        }
        [Authorize]
        public async Task<IActionResult> Paypal(Data.Models.Order order)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró a metodo de pago Paypal", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            double data = Convert.ToDouble(order.Total);
            ViewBag.Total=data.ToString(CultureInfo.CreateSpecificCulture("en-US"));
            return View(order);
        }
        [Authorize]
        public async Task<IActionResult> Deposito(Data.Models.Order order)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró a metodo de pago Deposito", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            double data = Convert.ToDouble(order.Total);
            ViewBag.Total = data.ToString(CultureInfo.CreateSpecificCulture("en-US"));
            return View(order);
        }
        [Authorize]
        public async Task<IActionResult> MercadoPago(Data.Models.Order order)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró a metodo de pago Mercado Pago", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            var lista = context.OrderDetails.ToList().Where(p=>p.RefPago==order.RefPago);
            List<OrderDetail> details = new List<OrderDetail>();
            foreach(var i in lista)
            {
                details.Add(i);
            }
            //MercPago(details);
            double data = Convert.ToDouble(order.Total);
            ViewBag.Total = data.ToString(CultureInfo.CreateSpecificCulture("en-US"));
            return View(new MercadoPagoViewModel() { Order=order});
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> MercadoPago(MercadoPagoViewModel vm)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró a metodo de pago Mercado Pago", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            
            return View();
        }
        public async Task<IActionResult> Error(ErrorVM vm)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario redireccionado a error "+vm.DataError, Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            return View(vm);
        }
    }
}
