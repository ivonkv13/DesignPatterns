public class CheeseDecorator : IPizza
{
    private IPizza _pizza;

    public CheeseDecorator(IPizza pizza) => _pizza = pizza;

    public string GetDescription() => _pizza.GetDescription() + ", Cheese";
    public double GetCost() => _pizza.GetCost() + 1.25;
}
