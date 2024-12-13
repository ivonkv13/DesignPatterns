// Abstraction
public abstract class RemoteControl
{
    protected IDevice _device;

    protected RemoteControl(IDevice device)
    {
        _device = device;
    }

    public abstract void TogglePower();
}
