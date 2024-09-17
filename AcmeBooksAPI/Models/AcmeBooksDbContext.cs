using Microsoft.EntityFrameworkCore;
using AcmeBooksAPI.Models;

namespace AcmeBooks.Models
{
    public class AcmeBooksDbContext : DbContext
    {
        public AcmeBooksDbContext(DbContextOptions<AcmeBooksDbContext> options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Bookstore> Bookstores { get; set; }
        public DbSet<Employee>  Employees  { get; set; }

        

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
                new Genre { Id = 10, Title = "Adventure", Description = "Adventure literature" },
                new Genre { Id = 11, Title = "Educational", Description = "Adventure literature" }
            );

            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    Id = 1, FirstName = "William", LastName = "Shakespeare",
                    Biography = "English playwright, poet, and actor", BirthDate = new DateTime(1564, 4, 26),
                    Email = "william.shakespeare@example.com"
                },
                new Author
                {
                    Id = 2, FirstName = "Jane", LastName = "Austen",
                    Biography = "English novelist known for her romance novels", BirthDate = new DateTime(1775, 12, 16),
                    Email = "jane.austen@example.com"
                },
                new Author
                {
                    Id = 3, FirstName = "Mark", LastName = "Twain",
                    Biography = "American writer, humorist, and lecturer", BirthDate = new DateTime(1835, 11, 30),
                    Email = "mark.twain@example.com"
                },
                new Author
                {
                    Id = 4, FirstName = "Charles", LastName = "Dickens", Biography = "English writer and social critic",
                    BirthDate = new DateTime(1812, 2, 7), Email = "charles.dickens@example.com"
                },
                new Author
                {
                    Id = 5, FirstName = "Herman", LastName = "Melville",
                    Biography = "American novelist, short story writer, and poet", BirthDate = new DateTime(1819, 8, 1),
                    Email = "herman.melville@example.com"
                },
                new Author
                {
                    Id = 6, FirstName = "Mary", LastName = "Shelley",
                    Biography = "English novelist best known for her Gothic novel Frankenstein",
                    BirthDate = new DateTime(1797, 8, 30), Email = "mary.shelley@example.com"
                },
                new Author
                {
                    Id = 7, FirstName = "George", LastName = "Orwell",
                    Biography = "English novelist, essayist, and critic", BirthDate = new DateTime(1903, 6, 25),
                    Email = "george.orwell@example.com"
                },
                new Author
                {
                    Id = 8, FirstName = "J.R.R.", LastName = "Tolkien",
                    Biography = "English writer, poet, philologist, and academic", BirthDate = new DateTime(1892, 1, 3),
                    Email = "jrr.tolkien@example.com"
                },
                new Author
                {
                    Id = 9, FirstName = "Harper", LastName = "Lee",
                    Biography = "American novelist widely known for 'To Kill a Mockingbird'",
                    BirthDate = new DateTime(1926, 4, 28), Email = "harper.lee@example.com"
                },
                new Author
                {
                    Id = 10, FirstName = "Bram", LastName = "Stoker",
                    Biography = "Irish author best known for his Gothic horror novel Dracula",
                    BirthDate = new DateTime(1847, 11, 8), Email = "bram.stoker@example.com"
                },
                new Author
                {
                    Id = 11, FirstName = "J.D.", LastName = "Salinger",
                    Biography = "American writer known for his iconic novel 'The Catcher in the Rye'",
                    BirthDate = new DateTime(1919, 1, 1), Email = "jd.salinger@example.com"
                },
                new Author
                {
                    Id = 12, FirstName = "F. Scott", LastName = "Fitzgerald",
                    Biography = "American novelist and short story writer", BirthDate = new DateTime(1896, 9, 24),
                    Email = "f.scott.fitzgerald@example.com"
                },
                new Author
                {
                    Id = 13, FirstName = "Leo", LastName = "Tolstoy",
                    Biography = "Russian writer who is regarded as one of the greatest authors of all time",
                    BirthDate = new DateTime(1828, 9, 9), Email = "leo.tolstoy@example.com"
                },
                new Author
                {
                    Id = 14, FirstName = "Fyodor", LastName = "Dostoevsky",
                    Biography = "Russian novelist, short story writer, essayist, journalist, and philosopher",
                    BirthDate = new DateTime(1821, 11, 11), Email = "fyodor.dostoevsky@example.com"
                },
                new Author
                {
                    Id = 16, FirstName = "Aldous", LastName = "Huxley", Biography = "English writer and philosopher",
                    BirthDate = new DateTime(1894, 7, 26), Email = "aldous.huxley@example.com"
                }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1, Title = "Hamlet", ISBN = "978-1-86197-271-0", AuthorId = 1, GenreId = 1,
                    PublishDate = new DateTime(1603, 1, 1), Language = Language.English, Publisher = "Penguin",
                    Quantity = 10
                },
                new Book
                {
                    Id = 2, Title = "Pride and Prejudice", ISBN = "978-0-316-76948-8", AuthorId = 2, GenreId = 1,
                    PublishDate = new DateTime(1813, 1, 28), Language = Language.English, Publisher = "Penguin",
                    Quantity = 14
                },
                new Book
                {
                    Id = 3, Title = "Adventures of Huckleberry Finn", ISBN = "978-0-7432-7356-5", AuthorId = 3,
                    GenreId = 1, PublishDate = new DateTime(1884, 12, 10), Language = Language.English,
                    Publisher = "Harper & Brothers", Quantity = 3
                },
                new Book
                {
                    Id = 4, Title = "Great Expectations", ISBN = "978-0-141-43956-6", AuthorId = 4, GenreId = 1,
                    PublishDate = new DateTime(1861, 8, 1), Language = Language.English, Publisher = "Chapman & Hall",
                    Quantity = 6
                },
                new Book
                {
                    Id = 5, Title = "Moby-Dick", ISBN = "978-0-486-46730-0", AuthorId = 5, GenreId = 1,
                    PublishDate = new DateTime(1851, 11, 14), Language = Language.English,
                    Publisher = "Harper & Brothers", Quantity = 11
                },
                new Book
                {
                    Id = 6, Title = "Frankenstein", ISBN = "978-0-14-143947-1", AuthorId = 1, GenreId = 6,
                    PublishDate = new DateTime(1818, 1, 1), Language = Language.English,
                    Publisher = "Lackington, Hughes, Harding, Mavor & Jones", Quantity = 2
                },
                new Book
                {
                    Id = 7, Title = "1984", ISBN = "978-0-452-28423-4", AuthorId = 2, GenreId = 4,
                    PublishDate = new DateTime(1949, 6, 8), Language = Language.English, Publisher = "Secker & Warburg",
                    Quantity = 8
                },
                new Book
                {
                    Id = 8, Title = "The Hobbit", ISBN = "978-0-618-00221-3", AuthorId = 3, GenreId = 3,
                    PublishDate = new DateTime(1937, 9, 21), Language = Language.English,
                    Publisher = "George Allen & Unwin", Quantity = 0
                },
                new Book
                {
                    Id = 9, Title = "To Kill a Mockingbird", ISBN = "978-0-06-112008-4", AuthorId = 4, GenreId = 9,
                    PublishDate = new DateTime(1960, 7, 11), Language = Language.English,
                    Publisher = "J. B. Lippincott & Co.", Quantity = 7
                },
                new Book
                {
                    Id = 10, Title = "Dracula", ISBN = "978-0-452-01074-1", AuthorId = 5, GenreId = 6,
                    PublishDate = new DateTime(1897, 5, 26), Language = Language.English,
                    Publisher = "Archibald Constable and Company", Quantity = 5
                },
                new Book
                {
                    Id = 11, Title = "The Catcher in the Rye", ISBN = "978-0-316-76948-3", AuthorId = 2, GenreId = 1,
                    PublishDate = new DateTime(1951, 7, 16), Language = Language.English,
                    Publisher = "Little, Brown and Company", Quantity = 11
                },
                new Book
                {
                    Id = 12, Title = "The Great Gatsby", ISBN = "978-0-7432-7356-1", AuthorId = 3, GenreId = 10,
                    PublishDate = new DateTime(1925, 4, 10), Language = Language.English,
                    Publisher = "Charles Scribner's Sons", Quantity = 12
                },
                new Book
                {
                    Id = 13, Title = "War and Peace", ISBN = "978-0-14-044793-4", AuthorId = 4, GenreId = 9,
                    PublishDate = new DateTime(1869, 1, 1), Language = Language.Russian,
                    Publisher = "The Russian Messenger", Quantity = 15
                },
                new Book
                {
                    Id = 14, Title = "Crime and Punishment", ISBN = "978-0-14-044913-6", AuthorId = 5, GenreId = 9,
                    PublishDate = new DateTime(1866, 1, 1), Language = Language.Russian,
                    Publisher = "The Russian Messenger", Quantity = 4
                },
                new Book
                {
                    Id = 16, Title = "Brave New World", ISBN = "978-0-06-085052-4", AuthorId = 1, GenreId = 4,
                    PublishDate = new DateTime(1932, 8, 31), Language = Language.English, Publisher = "Chatto & Windus",
                    Quantity = 12
                },
                new Book
                {
                    Id = 17, Title = "The Divine Comedy", ISBN = "978-0-14-243722-3", AuthorId = 2, GenreId = 10,
                    PublishDate = new DateTime(1320, 1, 1), Language = Language.Italian, Publisher = "Penguin Classics",
                    Quantity = 13
                },
                new Book
                {
                    Id = 18, Title = "Les Misérables", ISBN = "978-0-14-044430-8", AuthorId = 3, GenreId = 9,
                    PublishDate = new DateTime(1862, 1, 1), Language = Language.French,
                    Publisher = "A. Lacroix, Verboeckhoven & Cie", Quantity = 9
                },
                new Book
                {
                    Id = 19, Title = "Don Quixote", ISBN = "978-0-14-243723-0", AuthorId = 4, GenreId = 10,
                    PublishDate = new DateTime(1605, 1, 16), Language = Language.Spanish,
                    Publisher = "Francisco de Robles", Quantity = 7
                },
                new Book
                {
                    Id = 20, Title = "Ulysses", ISBN = "978-0-679-72232-3", AuthorId = 5, GenreId = 10,
                    PublishDate = new DateTime(1922, 2, 2), Language = Language.English,
                    Publisher = "Shakespeare and Company", Quantity = 5
                },
                new Book
                {
                    Id = 22, Title = "Madame Bovary", ISBN = "978-0-14-044912-9", AuthorId = 8, GenreId = 5, 
                    PublishDate = new DateTime(1857, 12, 12), Language = Language.French, 
                    Publisher = "Michel Lévy Frères", Quantity = 10
                },
                new Book
                {
                    Id = 23, Title = "One Hundred Years of Solitude", ISBN = "978-0-06-088328-7", AuthorId = 9, GenreId = 2, 
                    PublishDate = new DateTime(1967, 5, 30), Language = Language.Spanish, 
                    Publisher = "Harper & Row", Quantity = 9
                },
                new Book
                {
                    Id = 24, Title = "The Brothers Karamazov", ISBN = "978-0-14-044924-2", AuthorId = 5, GenreId = 9, 
                    PublishDate = new DateTime(1880, 1, 1), Language = Language.Russian, 
                    Publisher = "The Russian Messenger", Quantity = 7
                },
                new Book
                {
                    Id = 25, Title = "Anna Karenina", ISBN = "978-0-14-303500-8", AuthorId = 4, GenreId = 9, 
                    PublishDate = new DateTime(1877, 4, 1), Language = Language.Russian, 
                    Publisher = "The Russian Messenger", Quantity = 6
                },
                new Book
                {
                    Id = 26, Title = "The Old Man and the Sea", ISBN = "978-0-684-80122-3", AuthorId = 10, GenreId = 1, 
                    PublishDate = new DateTime(1952, 9, 1), Language = Language.English, 
                    Publisher = "Charles Scribner's Sons", Quantity = 10
                },
                new Book
                {
                    Id = 27, Title = "The Scarlet Letter", ISBN = "978-0-14-243726-1", AuthorId = 6, GenreId = 1, 
                    PublishDate = new DateTime(1850, 3, 16), Language = Language.English, 
                    Publisher = "Ticknor, Reed & Fields", Quantity = 4
                },
                new Book
                {
                    Id = 28, Title = "Frankenstein", ISBN = "978-0-14-143947-1", AuthorId = 11, GenreId = 6, 
                    PublishDate = new DateTime(1818, 1, 1), Language = Language.English, 
                    Publisher = "Lackington, Hughes, Harding, Mavor & Jones", Quantity = 3
                },
                new Book
                {
                    Id = 29, Title = "Jane Eyre", ISBN = "978-0-14-144114-6", AuthorId = 12, GenreId = 5, 
                    PublishDate = new DateTime(1847, 10, 16), Language = Language.English, 
                    Publisher = "Smith, Elder & Co.", Quantity = 7
                },
                new Book
                {
                    Id = 30, Title = "The Count of Monte Cristo", ISBN = "978-0-14-044926-6", AuthorId = 13, GenreId = 10, 
                    PublishDate = new DateTime(1844, 8, 28), Language = Language.French, 
                    Publisher = "Penguin Books", Quantity = 6
                },
                new Book
                {
                    Id = 31, Title = "Beloved", ISBN = "978-0-452-26736-7", AuthorId = 14, GenreId = 5,
                    PublishDate = new DateTime(1987, 9, 16), Language = Language.English,
                    Publisher = "Alfred A. Knopf", Quantity = 8
                },
                new Book
                {
                    Id = 32, Title = "The Road", ISBN = "978-0-307-38789-9", AuthorId = 15, GenreId = 5,
                    PublishDate = new DateTime(2006, 9, 26), Language = Language.English,
                    Publisher = "Alfred A. Knopf", Quantity = 5
                },
                new Book
                {
                    Id = 33, Title = "In Cold Blood", ISBN = "978-0-679-74558-2", AuthorId = 16, GenreId = 4,
                    PublishDate = new DateTime(1966, 1, 17), Language = Language.English,
                    Publisher = "Random House", Quantity = 7
                },
                new Book
                {
                    Id = 34, Title = "Catch-22", ISBN = "978-0-684-83339-1", AuthorId = 17, GenreId = 6,
                    PublishDate = new DateTime(1961, 11, 10), Language = Language.English,
                    Publisher = "Simon & Schuster", Quantity = 9
                },
                new Book
                {
                    Id = 35, Title = "A Tale of Two Cities", ISBN = "978-0-486-42453-3", AuthorId = 18, GenreId = 1,
                    PublishDate = new DateTime(1859, 4, 30), Language = Language.English,
                    Publisher = "Chapman & Hall", Quantity = 6
                },
                new Book    
                {
                    Id = 36, Title = "Their Eyes Were Watching God", ISBN = "978-0-06-083867-6", AuthorId = 19, GenreId = 5,
                    PublishDate = new DateTime(1937, 9, 18), Language = Language.English,
                    Publisher = "J.B. Lippincott & Co.", Quantity = 5
                },
                new Book
                {
                    Id = 37, Title = "The Souls of Black Folk", ISBN = "978-0-14-018998-8", AuthorId = 20, GenreId = 9,
                    PublishDate = new DateTime(1903, 4, 18), Language = Language.English,
                    Publisher = "A.C. McClurg & Co.", Quantity = 4
                },
                new Book
                {
                    Id = 38, Title = "Go Tell It on the Mountain", ISBN = "978-0-385-33405-2", AuthorId = 21, GenreId = 5,
                    PublishDate = new DateTime(1953, 5, 18), Language = Language.English,
                    Publisher = "Knopf", Quantity = 7
                },
                new Book
                {
                    Id = 39, Title = "Invisible Man", ISBN = "978-0-679-60139-0", AuthorId = 22, GenreId = 5,
                    PublishDate = new DateTime(1952, 4, 14), Language = Language.English,
                    Publisher = "Random House", Quantity = 6
                },
                new Book
                {
                    Id = 40, Title = "The Bluest Eye", ISBN = "978-0-307-27551-6", AuthorId = 14, GenreId = 5,
                    PublishDate = new DateTime(1970, 6, 20), Language = Language.English,
                    Publisher = "Holt, Rinehart and Winston", Quantity = 8
                }
            );
            
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Springfield Elementary School" },
                new Customer { Id = 2, Name = "West End High School" },
                new Customer { Id = 3, Name = "Legacy University" }
            );

            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, CustomerId = 1, OrderDate = new DateTime(2023, 10, 1), TotalAmount = 100.50m },
                new Order { Id = 2, CustomerId = 2, OrderDate = new DateTime(2023, 10, 2), TotalAmount = 200.75m }
            );

            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem
                {
                    Id = 1, OrderId = 2, ISBN = "978-0-14-044793-4", BookTitle = "War and Peace", Quantity = 1,
                    Price = 50.25m
                },
                new OrderItem
                {
                    Id = 2, OrderId = 2, ISBN = "978-0-141-43956-6", BookTitle = "Great Expectations", Quantity = 1,
                    Price = 50.25m
                },
                new OrderItem
                {
                    Id = 3, OrderId = 2, ISBN = "978-0-316-76948-8", BookTitle = "Pride and Prejudice", Quantity = 2,
                    Price = 100.375m
                },
                new OrderItem
                {
                    Id = 4, OrderId = 2, ISBN = "978-0-452-01074-1", BookTitle = "Dracula", Quantity = 1,
                    Price = 100.375m
                }
            );
            
            modelBuilder.Entity<Bookstore>().HasData(
                new Bookstore
                {
                    Id = 1, Name = "Acme Books Soho", City = "London", Latitude = 51.5074, Longitude = -0.1276,
                    StoreType = StoreType.Bookstore
                },
                new Bookstore
                {
                    Id = 2, Name = "5th Ave Books Manhattan", City = "New York", Latitude = 40.7128,
                    Longitude = -74.0061, StoreType = StoreType.BookstoreCafe
                },
                new Bookstore
                {
                    Id = 3, Name = "Acme Books & Espresso", City = "Rome", Latitude = 41.9028, Longitude = 12.4964,
                    StoreType = StoreType.BookstoreCafe
                },
                new Bookstore
                {
                    Id = 4, Name = "Kaiser Wilhelm Books", City = "Berlin", Latitude = 52.52, Longitude = 13.405,
                    StoreType = StoreType.Bookstore
                },
                new Bookstore
                {
                    Id = 5, Name = "Acme Books Brooklyn", City = "New York", Latitude = 40.768113,
                    Longitude = -73.92788, StoreType = StoreType.Warehouse
                },
                new Bookstore
                {
                    Id = 6, Name = "Books of the Rising Sun", City = "Tokyo", Latitude = 40.7128, Longitude = -73.92788,
                    StoreType = StoreType.BookstoreCafe
                },
                new Bookstore
                {
                    Id = 7, Name = "Acme Books LA", City = "Los Angeles", Latitude = 34.0522, Longitude = -118.244,
                    StoreType = StoreType.Warehouse
                }
            );
            
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Alice Williams", Position = "Manager", HireDate = new DateTime(2020, 1, 15), Salary = 75000m },
                new Employee { Id = 2, Name = "Robert Johnson", Position = "Bookstore Associate", HireDate = new DateTime(2019, 3, 22), Salary = 58000m },
                new Employee { Id = 3, Name = "Wilma Gladstone", Position = "Developer", HireDate = new DateTime(2021, 5, 19), Salary = 92000m },
                new Employee { Id = 4, Name = "Alice Glastonbury", Position = "Bookstore Associate", HireDate = new DateTime(2018, 6, 5), Salary = 67000m },
                new Employee { Id = 5, Name = "Emily Davis", Position = "Manager", HireDate = new DateTime(2017, 7, 30), Salary = 78000m },
                new Employee { Id = 6, Name = "Michael Brown", Position = "Bookstore Associate", HireDate = new DateTime(2020, 8, 15), Salary = 59000m },
                new Employee { Id = 7, Name = "Patricia Wilson", Position = "Bookstore Associate", HireDate = new DateTime(2019, 9, 21), Salary = 95000m },
                new Employee { Id = 8, Name = "Christopher Miller", Position = "Designer", HireDate = new DateTime(2016, 10, 11), Salary = 68000m },
                new Employee { Id = 9, Name = "Laura Taylor", Position = "Bookstore Associate", HireDate = new DateTime(2018, 11, 23), Salary = 77000m },
                new Employee { Id = 10, Name = "Matthew Moore", Position = "Bookstore Associate", HireDate = new DateTime(2022, 12, 9), Salary = 60000m }
            );

        }
    }
}