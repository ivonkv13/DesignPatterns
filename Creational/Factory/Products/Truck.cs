using Factory.Interfaces;

namespace Factory.Products
{
    public class Truck : IVehicle
    {
        public void Drive() => Console.WriteLine("Driving a truck.");
    }
}