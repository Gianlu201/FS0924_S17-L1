using FS0924_S17_L1.Data;
using FS0924_S17_L1.Models;
using FS0924_S17_L1.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FS0924_S17_L1.Services
{
    public class AdminService
    {
        private readonly EpiLibraryDbContext _context;

        public AdminService(EpiLibraryDbContext context)
        {
            _context = context;
        }

        private async Task<bool> SaveAsync()
        {
            try
            {
                return await _context.SaveChangesAsync() > 0;
            }
            catch
            {
                return false;
            }
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

        public async Task<bool> AddBookAsync(AddBookViewModel addBookViewModel)
        {
            try
            {
                var book = new Book()
                {
                    Id = Guid.NewGuid(),
                    Title = addBookViewModel.Title,
                    Author = addBookViewModel.Author,
                    Category = addBookViewModel.Category,
                    Available = addBookViewModel.Available,
                    Cover = addBookViewModel.Cover,
                };

                _context.Books.Add(book);

                return await SaveAsync();
            }
            catch
            {
                return false;
            }
        }
    }
}
