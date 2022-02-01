using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Itstep.M3C2;

namespace Itstep
{
    class Program
    {

        static void Main(string[] args)
        {
            //Ex1.Exercise1();

            //Ex3.Exercise3();
            Book book = new Book("Book1", "M.Yakubov", "ItStep", "Edit#3", DateTime.Now, 600);
            Book book2 = new Book("Book2", "M.Yakubov2", "ItStep2", "Edit#4", DateTime.Now, 700);
            Console.WriteLine(book.Author);
            Library library1 = new Library() { Name = "Lib1", Address = "Kutuz", Book = book, Phone = "88005553535" };

        }

        class Library
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
            public Book Book { get; set; }
        }

        class Book
        {
            public Book(string name, string author, string publisher, string edition, DateTime year, int pageCount)
            {
                Name = name;
                Author = author;
                Publisher = publisher;
                Edition = edition;
                Year = year;
                PageCount = pageCount;
            }
            public string Name { get; }
            public string Author { get; }
            public string Publisher { get; }
            public string Edition { get; }
            public DateTime Year { get; }
            public int PageCount { get; }
        }
    }
}


