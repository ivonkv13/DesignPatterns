namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates new objects by copying an existing object.

            //Real-life analogy:
            //Cloning a "blueprint" to create a similar object.

            PrototypeCar car1 = new PrototypeCar { Model = "Sedan", Color = "Red" };
            PrototypeCar car2 = car1.Clone();
            car2.Color = "Blue";

            Console.WriteLine($"{car1.Model}, {car1.Color}"); // Sedan, Red
            Console.WriteLine($"{car2.Model}, {car2.Color}"); // Sedan, Blue
        }
    }
}
