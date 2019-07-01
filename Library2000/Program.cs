using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("In Search of Lost Time", "Marcel Proust", 2010, 34);
            Book b2 = new Book("Ulysses", "James Joyce", 1994, 27);
            Book b3 = new Book("Atonement","Ian McEwan", 2000, 35);
            Book b4 = new Book( "White Teeth", "Zadie Smith", 2005, 40);
            Book b5 = new Book("Mortals", "Norman Rush", 1998, 25);
            Book b6 = new Book("The Flamethrowers: A Novel", "Rachel Kushner", 2013, 30);

            BookManager.GetBooksAfter2000();
            BookManager.GetAveragePrice();
        }
    }
}
