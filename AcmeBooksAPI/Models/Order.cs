using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AcmeBooks.Models;

namespace AcmeBooksAPI.Models
{
    // customer can be null if the sale is in the bookstore
    // otherwise the customer is a school, uni, business, or book club
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer? Customer { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public decimal TotalAmount { get; set; }
        public int? CustomerId { get; set; }
    }
    

    public class OrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        [StringLength(13)]
        public string ISBN { get; set; }
        [StringLength(250)]
        public string BookTitle { get; set; }
    }
}

// params (bulk order of books for a school)
// raw string & string interpolation - messages about orders