using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using System.Collections.Generic;

namespace ComponentesMexica.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int Orderid { get; set; }
        public string Userid { get; set; }
        public int PCid { get; set; }
        public int Compid { get; set; }
        public int Sofid {get;set;}
        public string SHid { get; set; }
        public PCMR PCMR { get; set; }
        public SecondHand secondHand { get; set; }
        public Componente Componente { get; set; }
        public Software Software { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public string RefPago { get; set; }
    }
}