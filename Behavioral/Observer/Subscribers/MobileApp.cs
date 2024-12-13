
// Concrete Observers
public class MobileApp : IObserver
{
    private string _appName;

    public MobileApp(string appName) => _appName = appName;

    public void Update(string message) =>
        Console.WriteLine($"{_appName} received: {message}");
}
