
// Facade
public class TravelFacade
{
    private readonly FlightBooking _flightBooking;
    private readonly HotelBooking _hotelBooking;
    private readonly CarRental _carRental;

    public TravelFacade()
    {
        _flightBooking = new FlightBooking();
        _hotelBooking = new HotelBooking();
        _carRental = new CarRental();
    }

    public void BookTravelPackage(string from, string to, int hotelNights, int carDays)
    {
        Console.WriteLine("Starting travel package booking...");
        _flightBooking.BookFlight(from, to);
        _hotelBooking.BookHotel(to, hotelNights);
        _carRental.BookCar(to, carDays);
        Console.WriteLine("Travel package booked successfully!");
    }
}
