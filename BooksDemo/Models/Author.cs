using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BooksDemo.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        [StringLength(25, ErrorMessage ="First name maximum length is 25 characters")]
        public string FirstName { get; set; }
        [StringLength(25, ErrorMessage = "Last name maximum length is 25 characters")]
        [Required(ErrorMessage ="Last name is required")]
        public string LastName { get; set; }
    }
}
