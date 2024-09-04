using AcmeBooksAPI.Models;

namespace AcmeBooksAPI.Services;
// This is for schools, businesses, and book clubs to order books
public class OrderService
{
    public Order order { get; set; }
    public OrderService(Customer customer)
    {
        order = new Order  { Id=new Random().Next(10000), OrderDate = DateTime.Today };
        if (customer == null)
        {
            order.Customer =   new Customer { Id = 0, Name = "In-store Customer"}; 
        }
        else if (customer != null)
        {
            order.CustomerId = customer.Id;
            order.Customer = customer;
        }
    }

    public void AddToOrder(OrderItem orderItem)
    {
        order.OrderItems.Add(orderItem);
    }
    
    public string FinalizeAndPrintOrder()
    {
        var booksList = "Books: \n";
        foreach (var orderItem in order.OrderItems)
        {
            booksList += orderItem.BookTitle + "\n";
            order.TotalAmount += (orderItem.Price * orderItem.Quantity);
        }

        var summary = @"-----------------------" + "\n"
             + "Customer :" + order.Customer.Name + "\n"
             + "Order #: " + order.Id + "\n"
             + "Date: " + order.OrderDate + "\n"
             + "Total: " + order.TotalAmount + "\n"
             + "-----------------------" + "\n"
             + booksList;
        
        return summary;
    }
}