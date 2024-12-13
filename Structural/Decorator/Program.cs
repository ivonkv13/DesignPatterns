namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adds functionality to objects dynamically without modifying their structure.

            //Real-life analogy
            //Adding "toppings" to a pizza without altering the original pizza.

            IPizza pizza = new PlainPizza();
            pizza = new CheeseDecorator(pizza);
            pizza = new PepperoniDecorator(pizza);

            Console.WriteLine(pizza.GetDescription()); // Plain Pizza, Cheese, Pepperoni
            Console.WriteLine($"Total cost: ${pizza.GetCost()}"); // Total cost: $7.75
        }
    }
}
