using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaSklepowa
{
    public class Product
    {
        public Product(string barcode, string name, decimal nettoPrice)
        {
            Barcode = barcode;
            Name = name;
            NettoPrice = nettoPrice;
        }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public decimal NettoPrice { get; set; }

        public decimal BruttoPrice
        {
            get { return Math.Round(NettoPrice * 1.23m, 2); }
        }
    }
}
