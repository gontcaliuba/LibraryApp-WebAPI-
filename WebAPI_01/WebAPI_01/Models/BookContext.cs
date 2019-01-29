using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPI_01.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}