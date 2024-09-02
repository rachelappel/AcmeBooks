using AcmeBooks.Models;

namespace AcmeBooksAPI.Models
{


    public class Order
    {
        // customer can be null if the sale is in the bookstore
        // otherwise the customer is a school, uni, business, or book club
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        // Collection to hold multiple customers
        public ICollection<Customer> Customers { get; set; } = new List<Customer>();

        // Assuming there are order items associated
        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
        public decimal TotalAmount { get; set; }
    }
    

    public class OrderItem
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
    
}

// params (bulk order of books for a school)
// raw string & string interpolation - messages about orders