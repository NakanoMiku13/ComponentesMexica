using ComponentesMexica.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Repositories
{
    public class SW:GenId
    {
        private protected void SetData(ApplicationDbContext context)
        {
            var tickets = context.Tickets.ToArray();
            int NoWinner = new Random().Next(tickets.Length + 1);
            int NoWin = tickets[NoWinner].Numero;
            var user = context.Tickets.FirstOrDefault(p => p.Numero == NoWin);
            var CantTickets = context.Tickets.Where(p => p.userid == user.userid);
            var rifa = context.Rifas.FirstOrDefault(p => p.Active == true);
            var winner = new GanadorRifa()
            {
                id = SetId(context),
                NumeroWin = NoWin,
                Rifaid = rifa.id,
                CantidadTickets = CantTickets.Count(),
                userid = user.userid
            };
            rifa.GanadorUserid = winner.userid;
            rifa.NumeroWin = winner.NumeroWin;
            rifa.Rifado = DateTime.Now;
            SetDay(context, rifa);
            context.Update(rifa);
            context.Add(winner);
            context.SaveChanges();
        }
        protected private void SetDay(ApplicationDbContext context,Rifas rifa)
        {
            if (rifa.Active == true)
            {
                var xd = context.Timer.Find(1);
                if (xd == null)
                {
                    DateTime time = DateTime.Now;
                    time.AddDays(3);
                    var data = new Timer()
                    {
                        Data = time
                    };
                    context.Add(data);
                    context.SaveChanges();
                }
                else
                {
                    DateTime time = DateTime.Now;
                    time.AddDays(3);
                    xd.Data = time;
                    context.Update(xd);
                    context.SaveChanges();
                }
            }
        }
        public void SetWinner(ApplicationDbContext context) => SetData(context);
    }
}
