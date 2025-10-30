using LibraryManager.Models;
using System.Linq;

namespace LibraryManager.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Books.Any()) return;

            context.Books.AddRange(
                new Book { Title = "The Hobbit", Author = "J.R.R. Tolkien", PublishedYear = 1937, Genre = "Fantasy", IsAvailable = true },
                new Book { Title = "Clean Code", Author = "Robert C. Martin", PublishedYear = 2008, Genre = "Programming", IsAvailable = true }
            );
            context.SaveChanges();
        }
    }
}
