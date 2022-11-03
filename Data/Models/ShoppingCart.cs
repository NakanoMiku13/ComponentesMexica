using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class ShoppingCart
    {
        private readonly ApplicationDbContext context;
        public ShoppingCart(ApplicationDbContext context)
        {
            this.context = context;
        }
        public string ShoppingCartId {get;set;}
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public static ShoppingCart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<ApplicationDbContext>();
            string CartId = session.GetString("CartID") ?? Guid.NewGuid().ToString();
            session.SetString("CartID", CartId);
            return new ShoppingCart(context) { ShoppingCartId = CartId };
        }
        public void AddSecondHandToCart(SecondHand sc)
        {
            var shoppingcartItem = context.shoppingCartItems.SingleOrDefault(s => s.SegundaMano.id == sc.id && s.ShoppingCartID == ShoppingCartId);
            if (shoppingcartItem == null)
            {
                shoppingcartItem = new ShoppingCartItem
                {
                    ShoppingCartID = ShoppingCartId,
                    SegundaMano=sc,
                    Cantidad = 1
                };
                context.shoppingCartItems.Add(shoppingcartItem);
            }
            else
            {
                shoppingcartItem.Cantidad++;
            }
            context.SaveChanges();
        }
        public void AddPCMRToCart(PCMR pCMR)
        {
            var shoppingcartItem = context.shoppingCartItems.SingleOrDefault(s => s.PCMR.id == pCMR.id && s.ShoppingCartID == ShoppingCartId);
            if (shoppingcartItem == null)
            {
                shoppingcartItem = new ShoppingCartItem
                {
                    ShoppingCartID = ShoppingCartId,
                    PCMR=pCMR,
                    Cantidad = 1
                };
                context.shoppingCartItems.Add(shoppingcartItem);
            }
            else
            {
                shoppingcartItem.Cantidad++;
            }
            context.SaveChanges();
        }
        public void AddSoftWareToCart(Software soft)
        {
            var shoppingcartItem = context.shoppingCartItems.SingleOrDefault(s => s.Software.id == soft.id && s.ShoppingCartID == ShoppingCartId);
            if (shoppingcartItem == null)
            {
                shoppingcartItem = new ShoppingCartItem
                {
                    ShoppingCartID = ShoppingCartId,
                    Software = soft,
                    Cantidad = 1
                };
                context.shoppingCartItems.Add(shoppingcartItem);
            }
            else
            {
                shoppingcartItem.Cantidad++;
            }
            context.SaveChanges();
        }
        //Modificado
        public void AddToCart(Componente producto)
        {
            var shoppingcartItem = context.shoppingCartItems.SingleOrDefault(s => s.Componente.id == producto.id && s.ShoppingCartID == ShoppingCartId);
            if (shoppingcartItem == null)
            {
                shoppingcartItem = new ShoppingCartItem
                {
                    ShoppingCartID = ShoppingCartId,
                    Componente = producto,
                    Cantidad = 1
                };
                context.shoppingCartItems.Add(shoppingcartItem);
            }
            else
            {
                shoppingcartItem.Cantidad++;
            }
            context.SaveChanges();
        }
        public void RemoveOne(Componente producto,PCMR pc, SecondHand sc, Software soft)
        {
            if (producto != null)
            {
                var shop = context.shoppingCartItems.FirstOrDefault(s => s.Componente.id == producto.id && s.ShoppingCartID == ShoppingCartId);
                if (shop != null)
                {
                    if (shop.Cantidad > 1)
                    {
                        shop.Cantidad--;
                    }
                }
                context.Update(shop);
                context.SaveChanges();
            }
            else if (pc != null)
            {
                var shop = context.shoppingCartItems.FirstOrDefault(s => s.PCMR.id == pc.id && s.ShoppingCartID == ShoppingCartId);
                if (shop != null)
                {
                    if (shop.Cantidad > 1)
                    {
                        shop.Cantidad--;
                    }
                }
                context.Update(shop);
                context.SaveChanges();
            }
            else if (sc!=null)
            {
                var shop = context.shoppingCartItems.FirstOrDefault(s => s.SegundaMano.id == sc.id && s.ShoppingCartID == ShoppingCartId);
                if (shop != null)
                {
                    if (shop.Cantidad > 1)
                    {
                        shop.Cantidad--;
                    }
                }
                context.Update(shop);
                context.SaveChanges();
            }else if (soft!=null)
            {
                var shop = context.shoppingCartItems.FirstOrDefault(s => s.Software.id == soft.id && s.ShoppingCartID == ShoppingCartId);
                if (shop != null)
                {
                    if (shop.Cantidad > 1)
                    {
                        shop.Cantidad--;
                    }
                }
                context.Update(shop);
                context.SaveChanges();
            }

            
        }
        public void RemoveFromCart(Componente producto, PCMR pc, SecondHand sc, Software soft)
        {
            if (producto != null)
            {
                var shoppingcartItem = context.shoppingCartItems.SingleOrDefault(s => s.Componente.id == producto.id && s.ShoppingCartID == ShoppingCartId);
                context.shoppingCartItems.Remove(shoppingcartItem);
                context.SaveChanges();
            }
            else if (pc!=null)
            {
                var shoppingcartItem = context.shoppingCartItems.SingleOrDefault(s => s.PCMR.id == pc.id && s.ShoppingCartID == ShoppingCartId);
                context.shoppingCartItems.Remove(shoppingcartItem);
                context.SaveChanges();
            }
            else if (sc!=null)
            {
                var shoppingcartItem = context.shoppingCartItems.SingleOrDefault(s => s.SegundaMano.id == sc.id && s.ShoppingCartID == ShoppingCartId);
                context.shoppingCartItems.Remove(shoppingcartItem);
                context.SaveChanges();
            }
            else if (soft!=null)
            {
                var shoppingcartItem = context.shoppingCartItems.SingleOrDefault(s => s.Software.id == soft.id && s.ShoppingCartID == ShoppingCartId);
                context.shoppingCartItems.Remove(shoppingcartItem);
                context.SaveChanges();
            }
            
        }
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = context.shoppingCartItems.Where(c => c.ShoppingCartID == ShoppingCartId).Include(s => s.Componente).Include(s=>s.Software).Include(s=>s.PCMR).Include(s=>s.SegundaMano).ToList());
        }
        public void ClearCart()
        {
            var cartItems = context.shoppingCartItems.Where(cart => cart.ShoppingCartID == ShoppingCartId);
            context.shoppingCartItems.RemoveRange(cartItems);
            context.SaveChanges();
        }
        public double GetShoppingCartTotal()
        {
            double Total = 0;
            Total += Math.Round(Convert.ToDouble(context.shoppingCartItems.Where(c => c.ShoppingCartID == ShoppingCartId).Select(c => (Math.Round(c.Componente.PrecioVenta, 2) * c.Cantidad) ).Sum()), 2);
            Total += Math.Round(Convert.ToDouble(context.shoppingCartItems.Where(c => c.ShoppingCartID == ShoppingCartId).Select(c => (Math.Round(c.PCMR.PrecioVenta, 2) * c.Cantidad) ).Sum()), 2);
            Total += Math.Round(Convert.ToDouble(context.shoppingCartItems.Where(c => c.ShoppingCartID == ShoppingCartId).Select(c => (Math.Round(c.SegundaMano.PrecioVenta, 2) * c.Cantidad) ).Sum()), 2);
            Total += Math.Round(Convert.ToDouble(context.shoppingCartItems.Where(c => c.ShoppingCartID == ShoppingCartId).Select(c => (Math.Round(c.Software.Precio, 2) * c.Cantidad) ).Sum()), 2);
            return Total;
        }
    }
}
