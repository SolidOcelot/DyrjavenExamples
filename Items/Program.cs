using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    class Program
    {
        static void Main(string[] args)
        {
            Item i1 = new Item("Gloves", 5);
            Item i2 = new Item("Shirt", 15);
            Item i3 = new Item("Pants", 25);
            Item i4 = new Item("Shoes", 35);
            Item i5 = new Item("Hat", 5);

            ItemManager.GetItemsWithMinPrice();
        }
    }
}
