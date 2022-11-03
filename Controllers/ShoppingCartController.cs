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
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ComponentesMexica.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly ShoppingCart shoppingCart;
        private readonly UserManager<IdentityUser> userManager;
        protected Discount discount = new Discount();
        public ShoppingCartController(ApplicationDbContext context,ShoppingCart shopping,UserManager<IdentityUser>user)
        {
            this.context = context;
            shoppingCart = shopping;
            userManager = user;
        }
        public IActionResult PromoCode(ShoppingCartViewModel vm)
        {
            var desc = context.PromoCodes.FirstOrDefault(p => p.Code == vm.PromoCode);
            if (desc == null)
            {
                return View("Error", new ErrorVM() { DataError = "Código no valido" });
            }
            else
            {
                var userid = userManager.GetUserId(HttpContext.User);
                var usedPromo = context.UsedPromos.FirstOrDefault(P => P.UserID == userid && P.PromoCodeID != vm.PromoCode);
                if (usedPromo == null)
                {
                    decimal data = Convert.ToDecimal(shoppingCart.GetShoppingCartTotal());
                    decimal total = discount.ApplyDisc(data, desc.Desc);
                    var datas = shoppingCart.GetShoppingCartItems();
                    shoppingCart.ShoppingCartItems = datas;
                    var shop = new ShoppingCartViewModel()
                    {
                        ShoppingCart = shoppingCart,
                        ShoppingCartTotal = total
                    };
                    var usePromo = new UsedPromos()
                    {
                        UserID = userid,
                        PromoCodeID = desc.Code,
                        UsedCode = true
                    };
                    context.Add(usePromo);
                    context.SaveChanges();
                    return View(shop);
                }
                else
                {
                    var error = new ErrorVM()
                    {
                        DataError = "Descuento ya aplicado o caducado"
                    };
                    return RedirectToAction("Error", error);
                }
            }
        }
        public IActionResult Error(ErrorVM vm)
        {
            return View(vm);
        }
        [Authorize]
        public IActionResult Index()
        {
            var data = shoppingCart.GetShoppingCartItems();
            shoppingCart.ShoppingCartItems = data;
            var vm = new ShoppingCartViewModel()
            {
                ShoppingCart = shoppingCart,
                ShoppingCartTotal = Convert.ToDecimal(shoppingCart.GetShoppingCartTotal())
            };
            return View(vm);
        }
        public RedirectToActionResult AddToCart(string id,string category)
        {
            //Modificado
            if (category == "componente")
            {
                var selected = context.Componente.FirstOrDefault(p => p.id == Convert.ToInt32(id));
                if (selected != null)
                {
                    shoppingCart.AddToCart(selected);
                }
            }
            else if (category=="PCMR")
            {
                var selected = context.PCMR.FirstOrDefault(p => p.id == Convert.ToInt32(id));
                if (selected != null)
                {
                    shoppingCart.AddPCMRToCart(selected);
                }
            }
            else if(category=="software")
            {
                var selected = context.Softwares.FirstOrDefault(p => p.id == Convert.ToInt32(id));
                if (selected != null)
                {
                    shoppingCart.AddSoftWareToCart(selected);
                }
            }
            else if (category == "secondHand")
            {
                var selected = context.SecondHand.FirstOrDefault(p => p.id == id);
                if (selected != null)
                {
                    shoppingCart.AddSecondHandToCart(selected);
                }
            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult AddOne(string id,string category)
        {
            if (category == "componente")
            {
                var selected = context.Componente.FirstOrDefault(p => p.id == Convert.ToInt32(id));
                if (selected != null)
                {
                    shoppingCart.AddToCart(selected);
                }
            }
            else if (category == "PCMR")
            {
                var selected = context.PCMR.FirstOrDefault(p => p.id == Convert.ToInt32(id));
                if (selected != null)
                {
                    shoppingCart.AddPCMRToCart(selected);
                }
            }
            else if (category == "software")
            {
                var selected = context.Softwares.FirstOrDefault(p => p.id == Convert.ToInt32(id));
                if (selected != null)
                {
                    shoppingCart.AddSoftWareToCart(selected);
                }
            }
            else if (category == "secondHand")
            {
                var selected = context.SecondHand.FirstOrDefault(p => p.id == id);
                if (selected != null)
                {
                    shoppingCart.AddSecondHandToCart(selected);
                }
            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveOne(string id,string category)
        {
            if (category == "componente")
            {
                var selected = context.Componente.FirstOrDefault(p => p.id == Convert.ToInt32(id));
                if (selected != null)
                {
                    shoppingCart.RemoveOne(selected,null,null,null);
                }
            }
            else if (category == "PCMR")
            {
                var selected = context.PCMR.FirstOrDefault(p => p.id == Convert.ToInt32(id));
                if (selected != null)
                {
                    shoppingCart.RemoveOne(null,selected,null,null);
                }
            }
            else if (category == "software")
            {
                var selected = context.Softwares.FirstOrDefault(p => p.id == Convert.ToInt32(id));
                if (selected != null)
                {
                    shoppingCart.RemoveOne(null,null,null,selected);
                }
            }
            else if (category == "secondHand")
            {
                var selected = context.SecondHand.FirstOrDefault(p => p.id == id);
                if (selected != null)
                {
                    shoppingCart.RemoveOne(null,null,selected,null);
                }
            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveFromCart(string id,string category)
        {
            if (category == "componente")
            {
                var selected = context.Componente.FirstOrDefault(p => p.id == Convert.ToInt32(id));
                if (selected != null)
                {
                    shoppingCart.RemoveFromCart(selected, null, null, null);
                }
            }
            else if (category == "PCMR")
            {
                var selected = context.PCMR.FirstOrDefault(p => p.id == Convert.ToInt32(id));
                if (selected != null)
                {
                    shoppingCart.RemoveFromCart(null, selected, null, null);
                }
            }
            else if (category == "software")
            {
                var selected = context.Softwares.FirstOrDefault(p => p.id == Convert.ToInt32(id));
                if (selected != null)
                {
                    shoppingCart.RemoveFromCart(null, null, null, selected);
                }
            }
            else if (category == "secondHand")
            {
                var selected = context.SecondHand.FirstOrDefault(p => p.id == id);
                if (selected != null)
                {
                    shoppingCart.RemoveFromCart(null, null, selected, null);
                }
            }
            return RedirectToAction("Index");
        }
    }
}
