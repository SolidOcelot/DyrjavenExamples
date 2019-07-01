using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    static class ProductManager
    {
        public static List<Product> Products = new List<Product>();

        public static void ExpireDateLessThan14Days()
        {
            Console.WriteLine("List of products with less than 14 days till expire date:");
            foreach(Product p in Products)
            {
                if (p.ExpirationDateInDays < 14)
                {
                    Console.WriteLine($"{p.Number}-{p.Name} from {p.Manufacturer} " +
                        $"has {p.ExpirationDateInDays} days left.");
                }
            }
        }

        public static void AveragePrice()
        {
            decimal totalPrice = 0;

            foreach (Product p in Products)
            {
                totalPrice += p.Price;
            }

            Console.WriteLine($"The average price of all products is {totalPrice / Products.Count}.");
        }
    }
}
