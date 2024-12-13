// Refined Abstraction
public class AdvancedRemoteControl : RemoteControl
{
    public AdvancedRemoteControl(IDevice device) : base(device) { }

    public override void TogglePower()
    {
        Console.WriteLine("Toggling power...");
        _device.TurnOn();
        _device.TurnOff();
    }
}