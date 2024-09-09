namespace AcmeBooksAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class StaffPick
{
    
    public StaffPick(Book book, DateTime weekOf, int employeeId)
    {
        Book = book;
        BookId = book.Id;
        EmployeeId = employeeId;
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public DateTime WeekOf { get; init; }
    public int BookId { get; set; }
    public Book Book { get; set; }
}