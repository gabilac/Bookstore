using System;
using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class Book
    {
        [Key]//automatic
        public int BookId { get; set; }

        //collected variables
        [Required(ErrorMessage = "Title is required")] //all fields required
        public string Title { get; set; }
        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Publisher is required")]
        public string Publisher { get; set; }
        [Required(ErrorMessage = "ISBN is required")]
        [RegularExpression("[0-9]{3}-[0-9]{10}", ErrorMessage = "ISBN should be formatted as ###-##########")]
        public string Isbn { get; set; }
        [Required(ErrorMessage = "Classification/Category is required")]
        public string Class { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [DataType(DataType.Currency)] //formats price correctly
        public double Price { get; set; }
        [Required(ErrorMessage = "Page Count required")]
        public int PageCount { get; set; }

    }
}
