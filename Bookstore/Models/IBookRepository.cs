using System;
using System.Linq;

namespace Bookstore.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
