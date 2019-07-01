using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public int YearOfRelease { get; set; }
        public decimal Price { get; set; }

        public Book(string title, string authorName, int yearOfRelease, decimal price)
        {
            this.Title = title;
            this.AuthorName = authorName;
            this.YearOfRelease = yearOfRelease;
            this.Price = price;

            BookManager.Books.Add(this);
        }
    }
}
