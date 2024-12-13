
// Visitor Interface

// Visitable Interface

// Concrete Visitable Classes
public class Movie : IVisitable
{
    public void Accept(IVisitor visitor) => visitor.Visit(this);
}
