using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_01.Models;

namespace WebAPI_01.Controllers
{
    public class ValuesController : ApiController
    {
        BookContext db = new BookContext();

        public IEnumerable<Book> GetBooks()
        {
            return db.Books;
        }

        public Book GetBook (int id)
        {
            Book book = db.Books.Find(id);
            return book;
        }

        [HttpPost]
        public void CreateBook([FromBody]Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
        }

        [HttpPut]
        public void EditBook(int id, [FromBody]Book book)
        {
            if (id == book.Id)
            {
                db.Entry(book).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Deletebook(int id)
        {
            Book book = db.Books.Find(id);
            if (book != null)
            {
                db.Books.Remove(book);
                db.SaveChanges();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
                base.Dispose(disposing);
            }
        }
    }
}
