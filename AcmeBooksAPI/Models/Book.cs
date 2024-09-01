using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcmeBooks.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}-\d{1,5}-\d{1,7}-\d{1,7}-\d{1}$", ErrorMessage = "Invalid ISBN format.")]
        public string ISBN { get; set; }

        [Required]
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        [Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        public DateTime PublishDate { get; set; }

        [Required]
        public Language Language { get; set; }

        [MaxLength(200)] public string Publisher { get; set; }
        
    }
}
