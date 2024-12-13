using AbstractFactory.Interfaces;

public class MacOSButton : IButton
{
    public void Render() => Console.WriteLine("macOS Button");
}