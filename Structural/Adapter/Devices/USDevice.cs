
public class USDevice
{
    private readonly IUSSocket _socket;

    public USDevice(IUSSocket socket)
    {
        _socket = socket;
    }

    public void Charge()
    {
        Console.WriteLine("US device is charging...");
        _socket.ProvidePower();
    }
}


