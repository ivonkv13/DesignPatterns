using Factory.Interfaces;
using Factory.Products;

namespace Factory.Factories
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string vehicleType)
        {
            return vehicleType switch
            {
                "Car" => new Car(),
                "Truck" => new Truck(),
                _ => throw new ArgumentException("Unknown vehicle type")
            };
        }
    }
}