using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Repositories
{
    public class Discount
    {
        public decimal ApplyDisc(decimal Total, int desc)
        {
            double data = Convert.ToDouble(Total);
            double total = (data * desc);
            total /= 100;
            Total -= Convert.ToDecimal(total);
            if (Total < 0)
            {
                Total *= -1;
            }
            return Total;
        }
    }
}
