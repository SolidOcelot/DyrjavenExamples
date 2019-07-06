using System;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product p1 = new Product("Ham", "Germany", 20, 10);
            //Product p2 = new Product("Cheese", "Germany", 10, 15);
            //Product p3 = new Product("Milk", "Bulgaria", 8, 5);

            try
            {
                Console.WriteLine("Enter number of products:");
                int numberOfProducts = int.Parse(Console.ReadLine());

                string productName, productManufacturer;
                int productExpirationDays;
                decimal productPrice;

                for (int i = 0; i < numberOfProducts; i++)
                {
                    Console.WriteLine("Enter product name:");
                    productName = Console.ReadLine();
                    Console.WriteLine("Enter product manufacturer:");
                    productManufacturer = Console.ReadLine();
                    Console.WriteLine("Enter product expiration date in days:");
                    productExpirationDays = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter product price:");
                    productPrice = decimal.Parse(Console.ReadLine());

                    Product product = new Product(productName, productManufacturer,
                        productExpirationDays, productPrice);

                    Console.WriteLine("Product added.");
                }

                ProductManager.ExpireDateLessThan14Days();
                ProductManager.AveragePrice();
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Try again.");
                Main(args);
            }
            
        }
    }
}
