using System.Diagnostics.Tracing;

namespace AcmeBooksAPI.Models;

public class eBook : Book
{
    public FileFormat FileFormat { get; set; }
}
 