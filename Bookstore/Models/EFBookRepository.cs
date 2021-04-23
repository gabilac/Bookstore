using System;
using System.Linq;

namespace Bookstore.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookDb _context;

        //constructor
        public EFBookRepository(BookDb context)
        {
            _context = context; 
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
