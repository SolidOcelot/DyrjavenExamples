using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("Ham", "Germany", 20, 10);
            Product p2 = new Product("Cheese", "Germany", 10, 15);
            Product p3 = new Product("Milk", "Bulgaria", 8, 5);
            
            ProductManager.ExpireDateLessThan14Days();
            ProductManager.AveragePrice();
        }
    }
}
