namespace AcmeBooksAPI.Services
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
    }
}

// params (bulk order of books for a school)