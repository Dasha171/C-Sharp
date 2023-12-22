using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class BookDbInitializer : DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Война и мир", Author = "JI. Толстой", Price = 220 });
            db.Books.Add(new Book { Name = "Отшы и дети", Author = "H. Tyргенев", Price = 180 });
            db.Books.Add(new Book { Name = "чaйкa", Author = "A. чexoв", Price = 150 });
            base.Seed(db);
        }
    }
}