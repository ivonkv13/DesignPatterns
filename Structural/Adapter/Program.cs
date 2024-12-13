namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a European plug
            EuropeanPlug europeanPlug = new EuropeanPlug();

            // Use the adapter to allow a US device to work with the European plug
            IUSSocket adapter = new EuropeanToUSAdapter(europeanPlug);

            // Charge the US device
            USDevice usDevice = new USDevice(adapter);
            usDevice.Charge();
        }
    }
}


