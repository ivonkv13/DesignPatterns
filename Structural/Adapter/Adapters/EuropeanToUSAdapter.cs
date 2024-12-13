
public class EuropeanToUSAdapter : IUSSocket
{
    private readonly EuropeanPlug _europeanPlug;

    public EuropeanToUSAdapter(EuropeanPlug europeanPlug)
    {
        _europeanPlug = europeanPlug;
    }

    public void ProvidePower()
    {
        Console.WriteLine("Adapter in action: Converting European standard to US standard.");
        _europeanPlug.ProvidePowerInEuropeanStandard();
    }
}


