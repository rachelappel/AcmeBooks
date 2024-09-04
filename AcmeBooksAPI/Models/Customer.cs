using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcmeBooksAPI.Models
{
    public class Customer
    {
        // generic customer (guest) for point of sale
        // should map to primary ct
        // ors, immutability
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
    }


}