public abstract class CoffeeTemplate
{
    public void MakeCoffee()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddExtras();
    }

    protected void BoilWater() => Console.WriteLine("Boiling water...");
    protected abstract void Brew();
    protected void PourInCup() => Console.WriteLine("Pouring into cup...");
    protected abstract void AddExtras();
}
