using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPI_01.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed (BookContext db)
        {
            db.Books.Add(new Book { Name = "Pet Sematary", Author = "S.King", Id = 0, Year = 1983 });
            db.Books.Add(new Book { Name = "The Shining", Author = "S.King", Id = 1, Year = 1977 });
            db.Books.Add(new Book { Name = "Doctor Sleep", Author = "S.King", Id = 2, Year = 2013 });

            base.Seed(db);
        }
    }
}