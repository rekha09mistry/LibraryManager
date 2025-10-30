using Microsoft.EntityFrameworkCore;
using LibraryManager.Models;

namespace LibraryManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
