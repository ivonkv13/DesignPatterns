using Factory.Interfaces;

namespace Factory.Products
{
    public class Car : IVehicle
    {
        public void Drive() => Console.WriteLine("Driving a car.");
    }
}