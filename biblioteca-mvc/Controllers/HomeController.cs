using biblioteca_mvc.Database;
using biblioteca_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace biblioteca_mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using (BookContext db = new())
            {

                List<BookModel> books = db.Books.ToList();
                return View(books);
            }
        }

        public IActionResult Available()
        {
            using (BookContext db = new())
            {
                List<BookModel> availableBooks = db.Books.Where(book => book.Available).ToList();
                return View(availableBooks);
            }
        }

        public IActionResult NonAvailable()
        {
            using (BookContext db = new())
            {
                List<BookModel> nonAvailableBooks = db.Books.Where(book => !book.Available).ToList();
                return View(nonAvailableBooks);
            }
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}