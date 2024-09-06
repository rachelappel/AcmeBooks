using Microsoft.Build.Framework;

public class Bookstore
{
    [Required]
    public string Name { get; set; }
    [Required]
    public  string City { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public StoreType StoreType { get; set; } = StoreType.Bookstore;
    public int Id { get; set; }
}

public enum StoreType
{
    Bookstore,
    BookstoreCafe,
    Warehouse
}