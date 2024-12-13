namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Allows adding new operations to existing object structures without modifying their classes.

            //Real-life analogy:
            //A "tax auditor" can calculate taxes for different types of assets (properties, vehicles).

            List<IVisitable> items = new List<IVisitable> { new Book(), new Movie() };
            IVisitor visitor = new PriceCalculator();

            foreach (var item in items)
            {
                item.Accept(visitor);
            }
            // Output:
            // Calculating price for a book...
            // Calculating price for a movie...
        }
    }
}
