using ComponentesMexica.Data.Models;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Repositories
{
    public class Orders
    {
        protected MailSender sender = new MailSender();
        protected GenId gen = new GenId();
        protected NomiRefe refe = new NomiRefe();
        public void UpdateOrder(string refpago, ApplicationDbContext context)
        {
            var data = context.Orders.FirstOrDefault(p=>p.RefPago==refpago);
            var ord = context.OrderDetails.Where(p => p.RefPago == refpago);
            List<SecondHand> Lista = new List<SecondHand>();
            foreach (var item in ord)
            {
                var sh = context.SecondHand.FirstOrDefault(p => p.id == item.SHid);
                if (sh != null)
                {
                    Lista.Add(sh);
                }
            }
            if (Lista != null)
            {
                foreach (var item in Lista)
                {
                    var seller = context.Vendedor.FirstOrDefault(p => p.userid == item.SellerId);
                    var nomi = context.Nomina.FirstOrDefault(p => p.Sellerid == seller.id);
                    if (nomi == null)
                    {
                        var nom = new SellerM()
                        {
                            id = gen.SetId(context),
                            Referencia = refe.SetId(),
                            Sellerid = seller.id,
                            Updated = DateTime.Now,
                            Retired = false
                        };
                        context.Add(nom);
                        context.SaveChanges();
                        nomi = nom;
                    }
                    else
                    {
                        nomi.Updated = DateTime.Now;
                        nomi.Referencia = refe.SetId();
                        context.Update(nomi);
                        context.SaveChanges();
                    }
                    var usermail = context.Users.Find(seller.userid);
                    var ordetailcount = context.OrderDetails.FirstOrDefault(p => p.RefPago == refpago && p.SHid == item.id);
                    decimal at = ordetailcount.Cantidad * item.PrecioCompra;
                    nomi.Total += at;
                    context.Update(nomi);
                    context.SaveChanges();
                    sender.SendMailBuySH(seller.id, item, usermail.Email, ordetailcount.Cantidad, at);
                }
            }
            data.Acreditado = true;
            context.Update(data);
            context.SaveChanges();
        }
        public void UpdateSend(string refpago, ApplicationDbContext context)
        {
            var data = context.Orders.FirstOrDefault(p=>p.RefPago==refpago);
            data.Enviado = true;
            context.Update(data);
            context.SaveChanges();
        }
    }
}
