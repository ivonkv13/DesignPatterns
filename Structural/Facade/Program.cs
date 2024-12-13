namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Provides a unified interface to a set of interfaces in a subsystem. It simplifies the interaction between the client and the complex subsystem by hiding its complexity.

            //Real-life analogy:
            //travel booking system that involves multiple subsystems for booking flights, hotels, and cars. Instead of having the client interact with each subsystem individually, we create a TravelFacade to simplify the process.

            var travelFacade = new TravelFacade();

            // The client interacts with the facade, not the subsystems.
            travelFacade.BookTravelPackage("Sofia", "Varna", 5, 3);

        }
    }
}
