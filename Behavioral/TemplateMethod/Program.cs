using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Defines the skeleton of an algorithm in a base class but allows steps to be overridden by subclasses.

            //A "coffee-making process" follows the same general steps but may have variations (e.g., espresso, latte).

            CoffeeTemplate espresso = new Espresso();
            espresso.MakeCoffee();
            // Output:
            // Boiling water...
            // Brewing espresso...
            // Pouring into cup...
            // Adding sugar to espresso.

            CoffeeTemplate latte = new Latte();
            latte.MakeCoffee();
            // Output:
            // Boiling water...
            // Brewing latte...
            // Pouring into cup...
            // Adding milk and sugar to latte.
        }
    }
}
