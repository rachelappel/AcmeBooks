## Primary constructors

* Reduce code and clarify syntax
* Create a parameter that is necessary for any instance of a type
* C# 9 - Primary constructors in records
* C# 12 - Primary constructors in classes also

***
[Code]()
<br>
[Main](main.md)
***
Resources:

[Primary constructors](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/primary-constructors)


from https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/primary-constructors
something like
The following code initializes two readonly properties that are computed from primary constructor parameters:

public readonly struct Distance(double dx, double dy)
{ public readonly double Magnitude { get; } = Math.Sqrt(dx * dx + dy * dy);
public readonly double Direction { get; } = Math.Atan2(dy, dx);
}
The preceding code demonstrates a primary constructor used to initialize calculated readonly properties. The field initializers for Magnitude and Direction use the primary constructor parameters. The primary constructor parameters aren't used anywhere else in the struct. The preceding struct is as though you'd written the following code:

public readonly struct Distance
{public readonly double Magnitude { get; }
    public readonly double Direction { get; }
    public Distance(double dx, double dy)
    {
        Magnitude = Math.Sqrt(dx * dx + dy * dy);
        Direction = Math.Atan2(dy, dx);
    }
}
The new feature makes it easier to use field initializers when you need arguments to initialize a field or property.
---
or 

public override string ToString() => $"Account ID: {accountID}, Owner: {owner}, Balance: {CurrentBalance}";

The highlighted line shows that the ToString method uses the primary constructor parameters (owner and accountID) rather than the base class properties (Owner and AccountID). The result is that the derived class, SavingsAccount creates storage for those copies