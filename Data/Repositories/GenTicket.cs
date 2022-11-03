using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Repositories
{
    public class GenTicket
    {
        public int SetTicketNumber(ApplicationDbContext context)
        {
            int numero = GenNumber();
            var ticket = context.Tickets.FirstOrDefault(p => p.Numero == numero);
            if (ticket == null)
            {
                return numero;
            }
            else
            {
                return SetTicketNumber(context);
            }
        }
        protected int GenNumber()
        {
            int data = new Random().Next(1, 9999999);
            return data;
        }
    }
}
