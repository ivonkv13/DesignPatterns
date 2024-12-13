public class Latte : CoffeeTemplate
{
    protected override void Brew() => Console.WriteLine("Brewing latte...");
    protected override void AddExtras() => Console.WriteLine("Adding milk and sugar to latte.");
}