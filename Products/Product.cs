using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    class Product
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int ExpirationDateInDays { get; set; }
        public decimal Price { get; set; }

        static int counter = 1;

        public Product(string name, string manufacturer, int expirationFateInDays, decimal price)
        {
            this.Number = counter;
            counter++; 

            this.Name = name;
            this.Manufacturer = manufacturer;
            this.ExpirationDateInDays = expirationFateInDays;
            this.Price = price;

            ProductManager.Products.Add(this);
        }
    }
}
