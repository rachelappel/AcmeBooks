namespace AcmeBooksAPI.Models;

public class AudioBook : Book
{
    public string NarratorName { get; set; }
    public decimal Length { get; set; }
}