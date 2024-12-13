public class Espresso : CoffeeTemplate
{
    protected override void Brew() => Console.WriteLine("Brewing espresso...");
    protected override void AddExtras() => Console.WriteLine("Adding sugar to espresso.");
}
