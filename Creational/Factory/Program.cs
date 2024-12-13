using Factory.Factories;
using Factory.Interfaces;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates objects without specifying the concrete class. Instead, an interface or abstract class is used.

            //Real-Life Analogy:
            //A "vehicle factory" produces cars or trucks based on your request.
                        
            IVehicle vehicle1 = VehicleFactory.GetVehicle("Car");
            vehicle1.Drive(); // Driving a car.

            IVehicle vehicle2 = VehicleFactory.GetVehicle("Truck");
            vehicle2.Drive(); // Driving a truck.

            //IVehicle vehicle3 = VehicleFactory.GetVehicle("Bus");
            //vehicle3.Drive(); // Exception
        }
    }
}
