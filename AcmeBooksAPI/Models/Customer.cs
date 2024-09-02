namespace AcmeBooksAPI.Models
{
    public class Customer
    {
        // generic customer (guest) for point of sale
        // should map to primary ctors, immutability
        // also derive schools as customer or as an enum
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
    }


}