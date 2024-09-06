using System.Text.Json;
using AcmeBooksAPI.Models;

namespace AcmeBooksAPI.Services.BookInventoryManager;

public class BookInventoryManager
{
    private readonly HttpClient _httpClient = new();
    private const string url = "https://localhost:7090/api/books/GetBooksForInventory";
    private readonly List<Book> currentBooks;
    private List<Book> countedBooks = new();
    List<Book> notFoundBooks = new();

    public BookInventoryManager(List<Book> books)
    {
        currentBooks=books;
    }
   
    public bool CountBook(Book countedBook, int Quantity)
    {
        var currentBook = currentBooks.Find(b => b.ISBN == countedBook.ISBN);
       
        if (currentBook != null)
        {
            if (currentBook.ISBN == countedBook.ISBN && 
                currentBook.Title == countedBook.Title &&
                currentBook.PublishDate == countedBook.PublishDate) 
                {
                    if (currentBook.Quantity == Quantity)
                    {
                        return true;
                    }
                    return false;
                }

            // With records, you can simply compare record types like value types
            /*if (currentBook == countedBook)
            {
                countedBooks.Add(countedBook);
                return true;
            }*/

            notFoundBooks.Add(countedBook);
            return false;
        }
        return false;
    }
}