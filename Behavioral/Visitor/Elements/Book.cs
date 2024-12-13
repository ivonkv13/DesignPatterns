
// Visitor Interface

// Visitable Interface
// Concrete Visitable Classes
public class Book : IVisitable
{
    public void Accept(IVisitor visitor) => visitor.Visit(this);
}
