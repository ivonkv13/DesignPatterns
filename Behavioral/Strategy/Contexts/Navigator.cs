
// Strategy Interface

// Concrete Strategies

// Context
public class Navigator
{
    private IRouteStrategy _routeStrategy;

    public void SetStrategy(IRouteStrategy routeStrategy)
    {
        _routeStrategy = routeStrategy;
    }

    public void BuildRoute(string start, string end)
    {
        if (_routeStrategy == null)
        {
            throw new InvalidOperationException("Route strategy is not set.");
        }
        _routeStrategy.BuildRoute(start, end);
    }
}
