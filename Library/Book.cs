using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        public int Number { get; set; }
        public string AuthorName { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int YearOfRelease { get; set; }

        static int counter = 1;

        public Book(string authorName, string title, decimal price, int yearOfRelease)
        {
            this.Number = counter;
            counter++;

            this.AuthorName = authorName;
            this.Title = title;
            this.Price = price;
            this.YearOfRelease = yearOfRelease;

            BookManager.Books.Add(this);
        }
    }
}
