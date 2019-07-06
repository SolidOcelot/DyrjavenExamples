using System;
using System.Collections.Generic;

namespace Items
{
    static class ItemManager
    {
        public static List<Item> Items = new List<Item>();

        private static decimal GetMinPrice()
        {
            decimal minPrice = Decimal.MaxValue;

            foreach (Item item in Items)
            {
                if (item.Price < minPrice)
                {
                    minPrice = item.Price;
                }
            }
            return minPrice;
        }

        public static void GetItemsWithMinPrice()
        {
            Console.WriteLine("List of items with the min price:");
            foreach (Item item in Items)
            {
                if (item.Price == GetMinPrice())
                {
                    Console.WriteLine($"{item.Name} has the min price of {item.Price}.");
                }
            }
        }
    }
}
