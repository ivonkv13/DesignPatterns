
// Strategy Interface
// Concrete Strategies
public class FastestRoute : IRouteStrategy
{
    public void BuildRoute(string start, string end) =>
        Console.WriteLine($"Building fastest route from {start} to {end}.");
}
