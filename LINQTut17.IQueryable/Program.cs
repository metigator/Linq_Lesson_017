using LINQTut17.Data;
using System;
using System.Linq;

namespace LINQTut17.IQueryable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new BookContext();

            IQueryable<Book> books = db.Books;

            //Queryable

            var booksOver50 = books.Where(x => x.Price > 50);


            foreach (var item in booksOver50)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
