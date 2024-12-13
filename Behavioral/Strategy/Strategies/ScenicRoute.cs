
// Strategy Interface

// Concrete Strategies
public class ScenicRoute : IRouteStrategy
{
    public void BuildRoute(string start, string end) =>
        Console.WriteLine($"Building scenic route from {start} to {end}.");
}
