namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Separates abstraction from its implementation to allow independent development.

            //Real-life analogy:
            //A "remote control" can work with different types of devices (TV, projector) without being tied to one specific device.
            IDevice tv = new TV();
            RemoteControl remote = new AdvancedRemoteControl(tv);
            remote.TogglePower();
            // Output:
            // Toggling power...
            // TV is ON.
            // TV is OFF.
        }
    }
}
