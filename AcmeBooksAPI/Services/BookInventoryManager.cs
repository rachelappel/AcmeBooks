namespace AcmeBooksAPI.Services.BookInventoryManager;

public class BookInventoryManager
{
    private List<Book> _books = new List<Book>();
    
    public void AddBook(string ISBN, int quantity)
    {
        var book = new Book(ISBN, quantity);
        _books.Add(book);
    }

    public string GetInventoryReport()
    {
        /*var reportGenerator = new InventoryReportGenerator(_books);
        return reportGenerator.GenerateReport();*/
        return null;
    }
}
    
// File-local type for a Book
public class Book
{
    public Book(string isbn, int quantity)
    {
        ISBN = isbn;
        Quantity = quantity;
    }
    
    public string ISBN { get; set; }
    public int Quantity { get; set; }
}

// File-local type for generating inventory reports
public class InventoryReportGenerator
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
}