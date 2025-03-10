using FS0924_S17_L1.Data;
using FS0924_S17_L1.Models;
using FS0924_S17_L1.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FS0924_S17_L1.Services
{
    public class BookService
    {
        private readonly EpiLibraryDbContext _context;

        public BookService(EpiLibraryDbContext context)
        {
            _context = context;
        }

        public async Task<BooksListViewModel> GetAllBooksAsync()
        {
            try
            {
                var booksList = new BooksListViewModel();

                booksList.Books = await _context.Books.ToListAsync();

                return booksList;
            }
            catch
            {
                return new BooksListViewModel() { Books = new List<Book>() };
            }
        }
    }
}
