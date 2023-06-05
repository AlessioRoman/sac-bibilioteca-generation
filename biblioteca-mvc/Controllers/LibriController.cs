using biblioteca_mvc.Database;
using biblioteca_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace biblioteca_mvc.Controllers
{
    public class LibriController : Controller
    {
        public IActionResult Index()
        {
            using (BookContext db = new BookContext())
            {
                List<BookModel> books = db.Books.ToList();

                return View(books);
            }
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BookModel newBook)
        {
            if (!ModelState.IsValid)
            {
                return View(newBook);
            } else
            {
                using(BookContext db = new BookContext())
                {
                    db.Books.Add(newBook);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
        }
    }
}
