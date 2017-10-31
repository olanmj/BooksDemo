﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksDemo.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int PubDate { get; set; }
        public string Category { get; set; }
        public int AuthorID { get; set; }
        public Author Author { get; set; }
    }
}
