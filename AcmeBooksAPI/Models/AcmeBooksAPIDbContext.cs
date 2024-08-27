namespace AcmeBooks.Models;


    
using Microsoft.EntityFrameworkCore;

public class AcmeBooksAPIDbContext : DbContext
{
    public AcmeBooksAPIDbContext(DbContextOptions<AcmeBooksAPIDbContext> options) : base(options)
    {
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Genre> Genres { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite(@"Data Source=AcmeBooks.sqlite");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      
modelBuilder.Entity<Genre>().HasData(
    new Genre { Id = 1, Title = "Classic", Description = "Classic literature" },
    new Genre { Id = 2, Title = "Mystery", Description = "Mystery and thrillers" },
    new Genre { Id = 3, Title = "Fantasy", Description = "Fantasy literature" },
    new Genre { Id = 4, Title = "Science Fiction", Description = "Science fiction literature" },
    new Genre { Id = 5, Title = "Romance", Description = "Romantic literature" },
    new Genre { Id = 6, Title = "Horror", Description = "Horror literature" },
    new Genre { Id = 7, Title = "Non-Fiction", Description = "Non-fiction literature" },
    new Genre { Id = 8, Title = "Biography", Description = "Biographies" },
    new Genre { Id = 9, Title = "Historical", Description = "Historical works" },
    new Genre { Id = 10, Title = "Adventure", Description = "Adventure literature" }
);

modelBuilder.Entity<Author>().HasData(
    new Author { Id = 1, FirstName = "William", LastName = "Shakespeare", Biography = "English playwright, poet, and actor", BirthDate = new DateTime(1564, 4, 26), Email = "william.shakespeare@example.com" },
    new Author { Id = 2, FirstName = "Jane", LastName = "Austen", Biography = "English novelist known for her romance novels", BirthDate = new DateTime(1775, 12, 16), Email = "jane.austen@example.com" },
    new Author { Id = 3, FirstName = "Mark", LastName = "Twain", Biography = "American writer, humorist, and lecturer", BirthDate = new DateTime(1835, 11, 30), Email = "mark.twain@example.com" },
    new Author { Id = 4, FirstName = "Charles", LastName = "Dickens", Biography = "English writer and social critic", BirthDate = new DateTime(1812, 2, 7), Email = "charles.dickens@example.com" },
    new Author { Id = 5, FirstName = "Herman", LastName = "Melville", Biography = "American novelist, short story writer, and poet", BirthDate = new DateTime(1819, 8, 1), Email = "herman.melville@example.com" }
);

modelBuilder.Entity<Book>().HasData(
    new Book { Id = 1, Title = "Hamlet", ISBN = "978-1-86197-271-0", AuthorId = 1, GenreId = 1, PublishDate = new DateTime(1603, 1, 1), Language = Language.English, Publisher = "Penguin" },
    new Book { Id = 2, Title = "Pride and Prejudice", ISBN = "978-0-316-76948-8", AuthorId = 2, GenreId = 1, PublishDate = new DateTime(1813, 1, 28), Language = Language.English, Publisher = "Penguin" },
    new Book { Id = 3, Title = "Adventures of Huckleberry Finn", ISBN = "978-0-7432-7356-5", AuthorId = 3, GenreId = 1, PublishDate = new DateTime(1884, 12, 10), Language = Language.English, Publisher = "Harper & Brothers" },
    new Book { Id = 4, Title = "Great Expectations", ISBN = "978-0-141-43956-6", AuthorId = 4, GenreId = 1, PublishDate = new DateTime(1861, 8, 1), Language = Language.English, Publisher = "Chapman & Hall" },
    new Book { Id = 5, Title = "Moby-Dick", ISBN = "978-0-486-46730-0", AuthorId = 5, GenreId = 1, PublishDate = new DateTime(1851, 11, 14), Language = Language.English, Publisher = "Harper & Brothers" }
);
    }
}
