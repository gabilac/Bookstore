using System;
using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class Book
    {
        [Key]//automatic
        public int BookId { get; set; }

        //collected variables
        [Required] //all fields required
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Class { get; set; }
        [Required]
        [DataType(DataType.Currency)] //formats price correctly
        public float Price { get; set; }
    }
}
