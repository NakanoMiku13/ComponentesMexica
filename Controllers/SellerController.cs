using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ComponentesMexica.Data;
using ComponentesMexica.Data.Models;
using ComponentesMexica.Data.Repositories;
using ComponentesMexica.Data.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ComponentesMexica.Controllers
{
    [Authorize(Roles ="Seller")]
    public class SellerController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<IdentityUser> userManager;
        protected GenId gen = new GenId();
        public SellerController(ApplicationDbContext context,UserManager<IdentityUser>USER)
        {
            this.context = context;
            userManager = USER;
        }
        [Authorize(Roles ="Seller")]
        public IActionResult Index()
        {
            var userid = userManager.GetUserId(HttpContext.User);
            var data = context.Vendedor.FirstOrDefault(p => p.userid == userid);
            var Nomina = context.Nomina.FirstOrDefault(p => p.Sellerid == data.id);
            if (Nomina != null)
            {
                ViewBag.Nomina = Nomina;
            }
            return View(data);
        }
        [Authorize(Roles="Admin,Seller")]
        public IActionResult Orders()
        {
            var userid = context.Users.Find(userManager.GetUserId(HttpContext.User));
            var sellerid = context.Vendedor.FirstOrDefault(p=>p.userid==userid.Id);
            var data = context.OrdersSeller.Where(p => p.sellerid == sellerid.id);
            return View(data);
        }
        [Authorize(Roles ="Seller")]
        public IActionResult Retire(string RefPago, string Sellerid)
        {
            var Error = new ErrorVM();
            var seller = context.Vendedor.FirstOrDefault(p=>p.id==Sellerid);
            if(seller != null)
            {
                if (seller.Aceptado)
                {
                    if (seller.Active)
                    {
                        var d = context.Nomina.FirstOrDefault(p => p.Referencia == RefPago && p.Sellerid == Sellerid);
                        if (d.Total > 0)
                        {
                            if (d.Retired)
                            {
                                Error.DataError = "Tu efectivo fue retirado previamente, espera 48 horas para poder retirar nuevamente";
                                return View("Error", Error);
                            }
                            else
                            {
                                var dataS = context.RerporteSeller.FirstOrDefault(p => p.Sellerid == Sellerid);
                                if (dataS == null)
                                {
                                    var nomi = context.Nomina.FirstOrDefault(p => p.Referencia == RefPago && p.Sellerid == Sellerid && p.Retired == false);
                                    ViewBag.Nomi = nomi;
                                    return View();
                                }
                                else
                                {
                                    if (dataS.Cuenta < 3)
                                    {
                                        var nomi = context.Nomina.FirstOrDefault(p => p.Referencia == RefPago && p.Sellerid == Sellerid && p.Retired == false);
                                        ViewBag.Nomi = nomi;
                                        return View();
                                    }
                                    else
                                    {
                                        Error.DataError = "Tu cuenta está suspendida, si tienes más de tres reportes se suspende tu cuenta hasta finalizar las investigaciones y no puedes retirar el dinero.";
                                        return View("Error", Error);
                                    }
                                }
                            }
                        }
                        else
                        {
                            Error.DataError = "No cuentas con fondos como para poder retirar";
                            return View("Error",Error);
                        }
                    }
                    else
                    {
                        Error.DataError = "Tu cuenta esta inactiva, esto puede ser por varios motivos, desde tener muchos reportes, hasta que usted haya solicitado la suspensión de la cuenta.";
                        return View("Error", Error);
                    }
                }
                else
                {
                    Error.DataError = "Tu cuenta no ha sido aceptada por los administradores";
                    return View("Error", Error);
                }
            }
            else
            {
                Error.DataError = "El vendedor no existe o su cuenta fue eliminada";
                return View("Error", Error);
            }
        }
        [HttpPost]
        public IActionResult Retire(SellerRetire seller,string refe)
        {
            var data = context.Users.Find(userManager.GetUserId(HttpContext.User));
            var sellers = context.Vendedor.FirstOrDefault(p => p.userid == data.Id);
            var nomina = context.Nomina.FirstOrDefault(p => p.Sellerid == sellers.id);
            seller.Aproved = false;
            seller.id = gen.SetId(context);
            seller.ReferenciaSeller = refe;
            seller.ReferenciaRetiro = gen.SetId(context);
            seller.Total = nomina.Total;
            seller.Solicitado = DateTime.Now;
            nomina.Retired = true;
            nomina.Updated = DateTime.Now;
            nomina.Total = 0;
            context.Update(nomina);
            context.Add(seller);
            context.SaveChanges();
            return View("Aceptado");
        }
        [Authorize]
        public IActionResult Error(ErrorVM vm)
        {
            return View(vm);
        }
        public IActionResult Aceptado()
        {
            return View();
        }
    }
}
