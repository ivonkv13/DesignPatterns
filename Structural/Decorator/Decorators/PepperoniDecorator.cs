public class PepperoniDecorator : IPizza
{
    private IPizza _pizza;

    public PepperoniDecorator(IPizza pizza) => _pizza = pizza;

    public string GetDescription() => _pizza.GetDescription() + ", Pepperoni";
    public double GetCost() => _pizza.GetCost() + 1.50;
}