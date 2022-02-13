using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaSklepowa
{
    public class ShopService
    {
        public ShopService()
        {
            CreateWarehouse();
        }
        public List<Product> Warehouse { get; set; } = new List<Product>();
        public List<Product> Paragon { get; set; } = new List<Product>();

        private void CreateWarehouse()
        {
            Warehouse.Add(new Product("001", "Masło Extra", 6.50m));
            Warehouse.Add(new Product("002", "Chleb wiejski", 4.50m));
            Warehouse.Add(new Product("003", "Makaron Babuni", 9.20m));
            Warehouse.Add(new Product("004", "Dżem truskawkowy", 8.10m));
            Warehouse.Add(new Product("005", "Kiełbasa myśliwska", 29.00m));
            Warehouse.Add(new Product("006", "Szynka konserwowa", 22.00m));
            Warehouse.Add(new Product("007", "Chipsy paprykowe", 6.00m));
            Warehouse.Add(new Product("008", "Serek wiejski", 3.50m));
            Warehouse.Add(new Product("009", "Sól kuchenna", 2.70m));
            Warehouse.Add(new Product("010", "Cukier kryształ", 3.20m));
        }
    }
}

