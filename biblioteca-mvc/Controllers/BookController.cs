using biblioteca_mvc.Database;
using biblioteca_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace biblioteca_mvc.Controllers
{
    public class BookController1 : Controller
    {
        public IActionResult Index()
        {
            using (BookContext db = new BookContext())
            {
                List<BookModel> books = db.Books.ToList();

                return View(books);
            }
        }

        public IActionResult Create(BookModel bookToCreate)
        {
            using (BookContext context = new BookContext())
            {
                List<BookModel> bookCategories = context.Books.ToList();

                BookModel modelForView = new BookModel();
                modelForView.ImageUrl = new BookModel();
                modelForView.Ebook = bookCategories;

                return View("Create", modelForView);
            }
        }
    }

   
}
