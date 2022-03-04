using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace LINQTut17.Data
{
    public class BookContext : DbContext
    {  
        public DbSet<Book> Books { get; set; }
         

        public BookContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer($"Data Source= .; initial catalog = bookstore ; INTEGRATED SECURITY = SSPI;"); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new[] {
            new Book { Id = 10, Title = "Java: The Complete Reference", Author = "Herbert Schildt", Price = 52.12m },
            new Book { Id = 11, Title = "Oracle 11g", Author = "Joan Casteel",Price = 167.53m },
            new Book { Id = 12, Title = "Learn T-SQL", Author = " Brahmanand Shukla", Price = 37.99m },
            new Book { Id = 13, Title = "C++ Programming Language", Author = "C++ Programming Language",Price = 105.18m },
            new Book { Id = 14, Title = "PYTHON PROGRAMMING", Author = "Clive Campbell", Price = 41.99m },
            new Book { Id = 15, Title = "JavaScript: The Definitive", Author = " David Flanagan",  Price = 53.32m},
            new Book { Id = 16, Title = "LINQ In Action", Author = "Steve Eichert", Price = 45.99m},
            new Book { Id = 17, Title = "C# in Depth", Author = "Jon Skeet",  Price = 49.99m },
            new Book { Id = 18, Title = "Learning SQL", Author = "Learning SQL", Price = 46.26m },
            new Book { Id = 19, Title = "Fullstack Vue", Author = "Fullstack Vue",   Price = 51.07m },
            new Book { Id = 20, Title = "The Road to React", Author = "The Road to React",  Price = 37.08m },
            new Book { Id = 21, Title = "Moving To VB.NET", Author = "Dan Appleman", Price = 44.99m },
            new Book { Id = 22, Title = "Angular in Action", Author = "Jeremy Wilken",  Price = 59.99m }

            }
                );
        }
    }  
}

