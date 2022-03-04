using LINQTut17.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTut17.IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new BookContext();

            IEnumerable<Book> books = db.Books;
            
            //Enumerable
            var booksOver50 = books.Where(x => {
                Console.WriteLine($"Processing : {x.Id}");
                return x.Price > 50;
            });


            foreach (var item in booksOver50)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
