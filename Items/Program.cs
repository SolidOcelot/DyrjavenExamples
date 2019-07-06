using System;

namespace Items
{
    class Program
    {
        static void Main(string[] args)
        {
            //Item i1 = new Item("Gloves", 5);
            //Item i2 = new Item("Shirt", 15);
            //Item i3 = new Item("Pants", 25);
            //Item i4 = new Item("Shoes", 35);
            //Item i5 = new Item("Hat", 5);

            try
            {
                Console.WriteLine("Enter number of items:");
                int numberOfItems = int.Parse(Console.ReadLine());

                string itemName;
                decimal itemPrice;

                for (int i = 0; i < numberOfItems; i++)
                {
                    Console.WriteLine("Enter item name:");
                    itemName = Console.ReadLine();
                    Console.WriteLine("Enter item price:");
                    itemPrice = decimal.Parse(Console.ReadLine());

                    Item item = new Item(itemName, itemPrice);
                    Console.WriteLine("Item added.");
                }

                ItemManager.GetItemsWithMinPrice();
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Try again.");
                Main(args);
            }

        }
    }
}
