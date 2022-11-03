using ComponentesMexica.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public PCMR PCMR { get; set; }
        public Software Software { get; set; }
        public SecondHand SegundaMano { get; set; }
        public decimal ShoppingCartTotal { get; set; }
        public string PromoCode { get; set; }
    }
}
