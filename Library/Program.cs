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
            Book b1 = new Book("Marcel Proust", "In Search of Lost Time", 34, 2010);
            Book b2 = new Book("James Joyce", "Ulysses", 27, 2015);
            Book b3 = new Book("Ian McEwan", "Atonement", 35, 2000);
            Book b4 = new Book("Zadie Smith", "White Teeth", 40, 2005);
            Book b5 = new Book("Norman Rush", "Mortals", 25, 2012);
            Book b6 = new Book("Rachel Kushner", "The Flamethrowers: A Novel", 30, 2013);

            BookManager.GetBooksAfter2010();
            BookManager.GetAveragePrice();
        }
    }
}
