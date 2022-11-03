using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Models
{
    public class ShoppingCartItem
    {
        public int id { get; set; }
        public Componente Componente { get; set; }
        //Nuevo
        public PCMR PCMR { get; set; }
        public Software Software { get; set; }
        public SecondHand SegundaMano { get; set; }
        public int Cantidad { get; set; }
        public string ShoppingCartID { get; set; }
    }
}
