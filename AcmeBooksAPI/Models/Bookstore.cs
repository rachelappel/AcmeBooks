using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Bookstore
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Microsoft.Build.Framework.Required]
    public string Name { get; set; }
    [Microsoft.Build.Framework.Required]
    public  string City { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public StoreType StoreType { get; set; } = StoreType.Bookstore;
    
}

public enum StoreType
{
    Bookstore,
    BookstoreCafe,
    Warehouse
}