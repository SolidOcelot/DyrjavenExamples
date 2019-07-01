using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    static class BookManager
    {
        public static List<Book> Books = new List<Book>();

        public static void GetBooksAfter2010()
        {
            Console.WriteLine("Books, released after 2010: ");

            foreach (Book book in Books)
            {
                if (book.YearOfRelease > 2010)
                {
                    Console.WriteLine($"{book.Number} - Author: {book.AuthorName} - Title: " +
                        $"{book.Title}, released in {book.YearOfRelease}.");
                }
            }
        }

        public static void GetAveragePrice()
        {
            decimal totalPrice = 0;
            foreach (Book book in Books)
            {
                totalPrice += book.Price;
            }

            Console.WriteLine($"Average price is: {(totalPrice / Books.Count).ToString("#.##")}");
        }
    }
}
