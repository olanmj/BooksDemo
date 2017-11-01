using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BooksDemo.Models
{
    public class Book
    {
        public int BookID { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [Display(Name = "Publication Year")]
        [Required(ErrorMessage ="Publication year is required")]
        [Range(1000, 3000, ErrorMessage ="Invalid year")]
        public int PubDate { get; set; }
        [StringLength(25, ErrorMessage = "Category maximum length is 25 characters")]
        public string Category { get; set; }
        [Display(Name = "Author")]
        [Required(ErrorMessage ="Please select an author")]
        public int AuthorID { get; set; }
        public Author Author { get; set; }
    }
}
