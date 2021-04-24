using System;
using System.Collections;
using System.Collections.Generic;

namespace Bookstore.Models.ViewModels
{
    public class BookListViewModel
    {
        //book info
        public IEnumerable<Book> Books { get; set; }

        //paging
        public PagingInfo PagingInfo { get; set; }

    }
}
