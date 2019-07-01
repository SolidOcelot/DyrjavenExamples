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

        public static void GetBooksAfter2000()
        {
            Console.WriteLine("Books, released after 2000: ");

            foreach (Book book in Books)
            {
                if (book.YearOfRelease > 2000)
                {
                    Console.WriteLine($"Title: {book.Title} - Author: {book.AuthorName}" +
                        $" - Released: {book.YearOfRelease} - Price: {book.Price}.");
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
