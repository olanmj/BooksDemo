using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BooksDemo.Models
{
    public class BooksDBContext : DbContext
    {
        public BooksDBContext (DbContextOptions<BooksDBContext> options)
            : base(options)
        {
        }

        public DbSet<BooksDemo.Models.Book> Books { get; set; }
        public DbSet<BooksDemo.Models.Author> Authors { get; set; }
    }
}
