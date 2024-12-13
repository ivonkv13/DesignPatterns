
// Visitor Interface

// Visitable Interface

// Concrete Visitable Classes

// Concrete Visitor
public class PriceCalculator : IVisitor
{
    public void Visit(Book book) => Console.WriteLine("Calculating price for a book...");
    public void Visit(Movie movie) => Console.WriteLine("Calculating price for a movie...");
}