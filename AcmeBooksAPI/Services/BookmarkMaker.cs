namespace AcmeBooksAPI.Services;

public class BookmarkMakerService
{
    private string Author { get; set; }
    private string Birthday { get; set; }
    private string Biography { get; set; }
    private string? FamousQuote { get; set; }
    // do init onlys then convert ctor to primary
    public BookmarkMakerService(string author, DateTime birthday, string biography, string? famousQuote)
    {
        Author = author;
        Birthday = birthday.ToShortDateString();
        Biography = biography;
        FamousQuote = famousQuote;
    }

    public string PrintBookmark()
    {
        var text = Author + " was born on " + Birthday + " and famously said: \n"
                   + "\"" + FamousQuote + "\"\n"
                   + "More on " + Author + "...\n"
                   + Biography;
        Console.WriteLine(text);
        return text;
    }
}
