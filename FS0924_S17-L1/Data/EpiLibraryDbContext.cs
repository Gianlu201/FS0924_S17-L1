using FS0924_S17_L1.Models;
using Microsoft.EntityFrameworkCore;

namespace FS0924_S17_L1.Data
{
    public class EpiLibraryDbContext : DbContext
    {
        public EpiLibraryDbContext(DbContextOptions<EpiLibraryDbContext> options)
            : base(options)
        {
            // costruttore
        }

        public DbSet<Book> Books { get; set; }
    }
}
