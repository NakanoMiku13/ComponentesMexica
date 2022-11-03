using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComponentesMexica.Data;
using ComponentesMexica.Data.Models;
using ComponentesMexica.Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ComponentesMexica.Controllers
{
    [Authorize]
    public class MisComprasController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<IdentityUser> userManager;
        public MisComprasController(ApplicationDbContext context,UserManager<IdentityUser>User)
        {
            this.context = context;
            userManager = User;
        }
        protected string GetUser()
        {
            return userManager.GetUserId(HttpContext.User);
        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró en Index/MisCompras", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var userid = GetUser();
            var data = context.Orders.Where(p => p.userid == userid);
            ViewBag.OrderDetail = context.OrderDetails.Where(p=>p.Userid==userid);
            return View(data);
        }
        [Authorize]
        public async Task<IActionResult> Detail(string refpago)
        {
            var log = new Logs() { id = new GenId().SetId(context), log = "Usuario entró en Detail/MisCompras", Logged = DateTime.Now, userid = GetUser() };
            await context.AddAsync(log);
            await context.SaveChangesAsync();
            var userid = GetUser();
            var datas = context.Orders.Where(p => p.RefPago == refpago && p.userid == userid);
            var data = context.OrderDetails.Where(p => p.RefPago == refpago && p.Userid == userid);
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            foreach (var item in data)
            {
                item.Componente = context.Componente.Find(item.Compid);
                item.PCMR = context.PCMR.Find(item.PCid);
                item.Software = context.Softwares.Find(item.Sofid);
                item.secondHand = context.SecondHand.Find(item.SHid);
                orderDetails.Add(item);
            }
            return View(orderDetails);
        }
    }
}
