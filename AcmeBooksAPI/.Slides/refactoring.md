


## nullable references

[OrderService.cs](../Services/OrderService.cs)

Rider will show intention actions for the following line
`+ "Customer :" + order.Customer.Name + "\n"`

Because `Customer` can be null for an (in-store) guest customer 
vs a defined customer (School, business, book club), we know that 
this shouldn't be null and can either ! suppress warning or


```csharp
 public string FinalizeAndPrintOrder()
 {
     decimal total = 0;
     foreach (var orderItem in order.OrderItems)
     {
         total += (orderItem.Price * orderItem.Quantity);
     }
     var summary = @"-----------------------" + "\n" 
         + "Customer :" + order.Customer.Name + "\n"
         + "Order #: " + order.Id + "\n"
         + "Date: " + order.OrderDate + "\n"
         + "Total: " + order.TotalAmount + "\n" 
         + "-----------------------" + "\n";
     return summary;
 }
```