using System;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Models
{
    public class BookDb : DbContext
    {
        public BookDb (DbContextOptions<BookDb> options) : base (options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
