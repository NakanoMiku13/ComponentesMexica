using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ComponentesMexica.Data;
using ComponentesMexica.Data.Models;
using ComponentesMexica.Data.Repositories;
using ComponentesMexica.Data.TempModels;
using ComponentesMexica.Data.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ComponentesMexica.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly ShoppingCart shoppingCart;
        protected ReferenciaPago refi = new ReferenciaPago();
        protected Orders order = new Orders();
        protected MailSender sender = new MailSender();
        public OrdersController(ApplicationDbContext context,UserManager<IdentityUser>user,ShoppingCart shopping)
        {
            this.context = context;
            userManager = user;
            shoppingCart = shopping;
        }
        protected string GetUser()
        {
            return userManager.GetUserId(HttpContext.User);
        }
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> Hide(int id)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario ocultó una orden", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var data = context.Orders.Find(id);
            data.Visible = false;
            context.Update(data);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Show(int id)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario mostró orden", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var data = context.Orders.Find(id);
            data.Visible = true;
            context.Update(data);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [Authorize(Roles="Admin")]
        public async Task<IActionResult> Hiden()
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró en Hiden/Orders", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var data = context.Orders.ToList().Where(p => p.Visible == false);
            return View(data);
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró en Index/Orders", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var data = context.Orders.ToList().Where(p => p.Visible == true).OrderBy(p=>p.Ordenado);
            return View(data);
        }
        [Authorize(Roles ="Admin,Manager")]
        public async Task<IActionResult> UpdatePay(string refpago)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario actualizó un pago", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var orders = await context.Orders.FirstOrDefaultAsync(p => p.RefPago == refpago);
            var user = await context.Users.FindAsync(orders.userid);
            sender.SendPayConfirm(user);
            order.UpdateOrder(refpago,context);
            return RedirectToAction("Index");
        }
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> UpdateSend(string refpago)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario actualizó envio", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var data = context.Orders.FirstOrDefault(p=>p.RefPago==refpago);
            if (data.Acreditado)
            {
                order.UpdateSend(refpago, context);
                var orders = await context.Orders.FirstOrDefaultAsync(p => p.RefPago == refpago);
                var user = await context.Users.FindAsync(orders.userid);
                sender.SendConfirm(user);
                return RedirectToAction("Index");
            }
            else
            {
                var error = new ErrorVM()
                {
                    DataError = "Pago sin acreditar"
                };
                return RedirectToAction("Error", "Admin", error);
            }
            
        }
        [Authorize]
        public async Task<IActionResult> CheckOut(string dataid)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró en checkout", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            ViewBag.id = dataid;
            ViewData["Estados"] = new SelectList(context.Entidad.Select(p=>p.Estado).Distinct()); 
            return View();
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CheckOut(Order order,string sid)
        {
            decimal total = 0;
            var orders = shoppingCart.GetShoppingCartItems();
            shoppingCart.ShoppingCartItems = orders;
            var userid = GetUser();
            if (!string.IsNullOrEmpty(sid))
            {
                total = Convert.ToDecimal(sid);
            }
            else
            {
                total = Convert.ToDecimal(shoppingCart.GetShoppingCartTotal());
            }
            
            order.RefPago = refi.GenRef(userid, context);
            foreach (var item in shoppingCart.ShoppingCartItems)
            {
                var orderdetails = new OrderDetail()
                {
                    Orderid = order.id,
                    Userid = userid,
                    RefPago = order.RefPago
                };
                if (item.Componente != null)
                {
                    orderdetails.Compid = item.Componente.id;
                    orderdetails.Cantidad = item.Cantidad;
                    orderdetails.Total = item.Componente.PrecioVenta * item.Cantidad;
                }
                else if (item.PCMR != null)
                {
                    orderdetails.PCid = item.PCMR.id;
                    orderdetails.Cantidad = item.Cantidad;
                    orderdetails.Total = item.PCMR.PrecioVenta * item.Cantidad;
                }
                else if (item.Software != null)
                {
                    orderdetails.Sofid = item.Software.id;
                    orderdetails.Cantidad = item.Cantidad;
                    orderdetails.Total = item.Software.Precio * item.Cantidad;
                }
                else if (item.SegundaMano != null)
                {
                    orderdetails.SHid = item.SegundaMano.id;
                    orderdetails.Cantidad = item.Cantidad;
                    orderdetails.Total = item.SegundaMano.PrecioVenta * item.Cantidad;
                }
                await context.AddAsync(orderdetails);
                await context.SaveChangesAsync();
            }
            order.Visible = true;
            var user = await context.Users.FindAsync(userid);
            order.Mail = user.Email;
            user.PhoneNumber = order.Numero;
            order.Ordenado = DateTime.Now;
            order.Total = total;
            order.userid = userid;
            context.Update(user);
            await context.AddAsync(order);
            await context.SaveChangesAsync();
            ViewData["Estados"] = new SelectList(context.Entidad, "Estado", "Estado", order.Estado);
            var x = new Temporal()
            {
                id = order.id.ToString()
            };
            return RedirectToAction("Fase1",x);
        }
        [Authorize]
        public async Task<IActionResult> Fase1(Temporal temp)
        {
            int id = Convert.ToInt32(temp.id);
            var order = await context.Orders.FindAsync(id);
            var query = context.Entidad.Where(x=>x.Estado==order.Estado).Select(p=>p.DataI).Distinct();
            ViewData["CP"] = new SelectList(query);
            ViewBag.id = order.id;
            return View(order);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Fase1(Order order)
        {
            var orders = await context.Orders.FindAsync(order.id);
            orders.CP = order.CP;
            context.Update(orders);
            await context.SaveChangesAsync();
            var query = context.Entidad.Where(x => x.Estado == order.Estado).Select(p => p.DataI).Distinct();
            ViewData["CP"] = new SelectList(query,order.CP);
            var x = new Temporal()
            {
                id = order.id.ToString()
            };
            return RedirectToAction("Fase2",x);
        }
        [Authorize]
        public async Task<IActionResult> Fase2(Temporal data)
        {
            int id = Convert.ToInt32(data.id);
            var order = await context.Orders.FindAsync(id);
            ViewBag.id = id;
            ViewData["Asenta"] = new SelectList(context.Entidad.Where(x => x.DataI == order.CP).Select(p => p.Asenta).Distinct());
            return View(order);
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Fase2(Order order,int dataid)
        {
            var orders = await context.Orders.FindAsync(dataid);
            orders.Colonia = order.Colonia;
            orders.MetodoEnvio = order.MetodoEnvio;
            if (order.MetodoEnvio == "Express")
            {
                orders.Total += 250;
            }
            else if(order.MetodoEnvio == "Strd")
            {
                orders.Total += 150;
            }
            else if(order.MetodoEnvio == "CorreosMexico")
            {
                orders.Total += 250;
            }
            context.Update(orders);
            await context.SaveChangesAsync();
            shoppingCart.ClearCart();
            ViewData["Asenta"] = new SelectList(context.Entidad.Where(x => x.CP == order.CP).Select(p => p.Asenta).Distinct(),order.Colonia);
            var data = new PaymethodViewModel()
            {
                PayMethod = orders.MetodoPago,
                Refe = orders.RefPago
            };
            var user = await context.Users.FindAsync(orders.userid);
            var orderdetail = context.OrderDetails.ToList().Where(p=>p.RefPago==orders.RefPago);
            List<OrderDetail> list = new List<OrderDetail>();
            var datas = shoppingCart.GetShoppingCartItems();
            shoppingCart.ShoppingCartItems = datas;
            sender.SendMailUserBuyTickey(user,orders,datas);
            sender.SendMailAdminBuy(data.Refe,orders.id.ToString());
            return RedirectToAction("RedirectPay","Paymethod",data);
        }
    }
}

