using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Repositories
{
    public class Prices
    {
        private float Comission = 0.0395f;
        float[] Comis = { 0.012f, 0.015f, 0.019f, 0.02f, 0.06f };
        public decimal SellPrice(decimal BuyPrice)
        {
            decimal com = Convert.ToDecimal(Comission);
            if (BuyPrice >= 10000)
            {
                
                decimal gan = Convert.ToDecimal(Comis[0]);
                return total(gan, BuyPrice, com);
            }
            else if (BuyPrice >= 8000)
            {
                decimal gan = Convert.ToDecimal(Comis[1]);
                return total(gan, BuyPrice, com);
            }
            else if (BuyPrice >= 6000)
            {
                decimal gan = Convert.ToDecimal(Comis[2]);
                return total(gan, BuyPrice, com);
            }
            else if (BuyPrice >= 2000)
            {
                decimal gan = Convert.ToDecimal(Comis[3]);
                return total(gan, BuyPrice, com);
            }
            else
            {
                decimal gan = Convert.ToDecimal(Comis[4]);
                return total(gan, BuyPrice, com);
            }
        }
        private protected decimal total(decimal ganancia, decimal buy, decimal com)
        {
            decimal x = buy + (buy * ganancia);
            decimal data = x + (x * com) + 4;
            return data;
        }
        private protected decimal Ganance(decimal total, decimal Comission, decimal buy)
        {
            decimal data = total;
            data -= Comission;
            data -= buy;
            return data;
        }
        private protected decimal Comi(decimal total, decimal Buy, decimal percent)
        {
            decimal data = total;
            data -= Buy;
            data -= (Buy * percent);
            return data;
        }
        public decimal Gana(decimal BuyPrice)
        {
            decimal com = Convert.ToDecimal(Comission);
            decimal data = 0;
            if (BuyPrice >= 10000)
            {
                decimal gan = Convert.ToDecimal(Comis[0]);
                data = total(gan, BuyPrice, com);
                return Ganance(data, Comi(data, BuyPrice, gan), BuyPrice);
            }
            else if (BuyPrice >= 8000)
            {
                decimal gan = Convert.ToDecimal(Comis[1]);
                data = total(gan, BuyPrice, com);
                return Ganance(data, Comi(data, BuyPrice, gan), BuyPrice);
            }
            else if (BuyPrice >= 6000)
            {
                decimal gan = Convert.ToDecimal(Comis[2]);
                data = total(gan, BuyPrice, com);
                return Ganance(data, Comi(data, BuyPrice, gan), BuyPrice);
            }
            else if (BuyPrice >= 2000)
            {
                decimal gan = Convert.ToDecimal(Comis[3]);
                data = total(gan, BuyPrice, com);
                return Ganance(data, Comi(data, BuyPrice, gan), BuyPrice);
            }
            else
            {
                decimal gan = Convert.ToDecimal(Comis[4]);
                data = total(gan, BuyPrice, com);
                return Ganance(data, Comi(data, BuyPrice, gan), BuyPrice);
            }
        }
        public decimal Com(decimal BuyPrice)
        {
            decimal com = Convert.ToDecimal(Comission);
            decimal data = 0;
            if (BuyPrice >= 10000)
            {
                decimal gan = Convert.ToDecimal(Comis[0]);
                data = total(gan, BuyPrice, com);
                return Comi(data, BuyPrice, gan);
            }
            else if (BuyPrice >= 8000)
            {
                decimal gan = Convert.ToDecimal(Comis[1]);
                data = total(gan, BuyPrice, com);
                return Comi(data, BuyPrice, gan);
            }
            else if (BuyPrice >= 6000)
            {
                decimal gan = Convert.ToDecimal(Comis[2]);
                data = total(gan, BuyPrice, com);
                return Comi(data, BuyPrice, gan);
            }
            else if (BuyPrice >= 2000)
            {
                decimal gan = Convert.ToDecimal(Comis[3]);
                data = total(gan, BuyPrice, com);
                return Comi(data, BuyPrice, gan);
            }
            else
            {
                decimal gan = Convert.ToDecimal(Comis[4]);
                data = total(gan, BuyPrice, com);
                return Comi(data, BuyPrice, gan);
            }
        }
        public decimal SellerPrices(decimal Precio)
        {
            double data = Convert.ToDouble(Precio);
            double total = 0;
            double comission = 0.03;
            double comissionPay = 0.0395;
            total = data + (data * comission);
            total += (total * comissionPay) + 4;
            return Convert.ToDecimal(total);
        }
    }
}