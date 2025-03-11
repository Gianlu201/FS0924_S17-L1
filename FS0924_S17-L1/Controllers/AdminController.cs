using FS0924_S17_L1.Services;
using FS0924_S17_L1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FS0924_S17_L1.Controllers
{
    public class AdminController : Controller
    {
        private readonly AdminService _adminService;

        public AdminController(AdminService adminService)
        {
            _adminService = adminService;
        }

        public async Task<IActionResult> Index()
        {
            var booksList = await _adminService.GetAllBooksAsync();

            return View(booksList);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddBookViewModel addBookViewModel)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Error while saving data into database";
                return RedirectToAction("Index");
            }

            var result = await _adminService.AddBookAsync(addBookViewModel);

            if (!result)
            {
                TempData["Error"] = "Error while saving data into database";
            }

            return RedirectToAction("Index");
        }
    }
}
