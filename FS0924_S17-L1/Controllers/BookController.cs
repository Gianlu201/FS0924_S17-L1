using System.Threading.Tasks;
using FS0924_S17_L1.Services;
using Microsoft.AspNetCore.Mvc;

namespace FS0924_S17_L1.Controllers
{
    public class BookController : Controller
    {
        private readonly BookService _bookService;

        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }

        public async Task<IActionResult> Index()
        {
            var booksList = await _bookService.GetAllBooksAsync();

            return View(booksList);
        }
    }
}
