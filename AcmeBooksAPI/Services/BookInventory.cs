using System.Text.Json;
using AcmeBooksAPI.Models;

namespace AcmeBooksAPI.Services.BookInventoryManager;

// File-local type for a Book
/*file class Book
{
    public Book(string ISBN, int Quantity)
    {
        this.ISBN = ISBN;
        this.Quantity = Quantity;
    }
    public string ISBN { get; set; } 
    public int Quantity { get; set; }
}*/

// File-local type for generating inventory reports
/*public class InventoryReportGenerator
{
    private readonly List<Book> _books;

    public InventoryReportGenerator(List<Book> books)
    {
        _books = books;
    }

    public string GenerateReport()
    {
        var report = "Inventory Report:\n";
        foreach (var book in _books)
        {
            report += $"- {book.ISBN} | {book.Quantity}\n";
        }
        return report;
    }
}*/
/*public class BookCounter
{
    public void CountBook(Book book)
    {
        /*var foundBook = currentBooks.Find(b => b.ISBN == book.ISBN);
        if (foundBook != null)
        {
            if (foundBook.ISBN == book.ISBN)
            {
                countedBooks.Add(book);
            }
            
            if (foundBook == book)
            {
                countedBooks.Add(book);
            }
            else
            {
                notFoundBooks.Add(book);
            }
        }#1#
    }
}*/
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
        var h1 = currentBook.GetHashCode();
        var h2 = countedBook.GetHashCode();
        
        if (currentBook != null)
        {
            if (currentBook.ISBN == countedBook.ISBN)
            {
                if (currentBook.Quantity == Quantity)
                {
                    countedBook.Quantity = Quantity;
                    countedBooks.Add(countedBook);
                    return true;
                }
                return false;
            }
            
            if (currentBook == countedBook)
            {
                countedBooks.Add(countedBook);
                return true;
            }
            
            notFoundBooks.Add(countedBook);
            return false;
            
        }
        return false;
    }
}