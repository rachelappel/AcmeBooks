using AcmeBooksAPI.Models;

namespace AcmeBooksAPI.Services
{
    public class EditorsPicks
    {
        public void RunWeeklyPicks(DateTime forDate)
        {
            
var books = new List<Book>
{
    new Book { Id = 1, Title = "Hamlet", ISBN = "978-1-86197-271-0", AuthorId = 1, GenreId = 1, PublishDate = new DateTime(1603, 1, 1), Language = Language.English, Publisher = "Penguin" },
    new Book { Id = 2, Title = "Pride and Prejudice", ISBN = "978-0-316-76948-8", AuthorId = 2, GenreId = 1, PublishDate = new DateTime(1813, 1, 28), Language = Language.English, Publisher = "Penguin" },
    new Book { Id = 3, Title = "Adventures of Huckleberry Finn", ISBN = "978-0-7432-7356-5", AuthorId = 3, GenreId = 1, PublishDate = new DateTime(1884, 12, 10), Language = Language.English, Publisher = "Harper & Brothers" }
};
        }
        // init only setters (editor's picks)
        // params collection
        // pattern matching (match by genre)
    }
}