## Refactorings in this talk:

## Modern C# features

* [Top-level statements](top-level-statements.md) Program
* [Global usings](global-usings.md) any file
* [File-scoped types](file-scoped.md) schedule
* [Nullable references](nullable.md) multi
* [Raw strings](raw-strings.md)  orderservice
* [String interpolation](string-interpolation.md) booklocator
* [Switch expression](switch-expression.md) locator
* [Pattern matching](pattern-matching.md) multi
* [Primary constructors](primary-ctor.md) (authorhighlights)
* [Init-only setters](init-only-setters.md) (authorhighlights (maybe staffpicks))
* [Record types](record-types.md) bookinventory
* [Params collection](params-collection.md) StaffPicks
* [Pattern matching](pattern-matching.md) multi


## Notes

### nullable references

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

### Records

* Records add another way to define types. 
* You use class definitions to create object-oriented hierarchies that focus on the responsibilities and behavior of objects. 
* You create struct types for data structures that store data and are small enough to copy efficiently. 
* You create record types when you want value-based equality and comparison, don't want to copy values, and want to use reference variables. 
* You create record struct types when you want the features of records for a type that is small enough to copy efficiently.

### Pattern Matching

BooksController line 48/50, in the null checks you can do a pattern check

```csharp
string authorInitial = book.Author != null ? book.Author.LastName : "";
string genre = book.Genre != null ? book.Genre.Title : "Unknown";
```
