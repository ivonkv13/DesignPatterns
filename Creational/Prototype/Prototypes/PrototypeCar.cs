public class PrototypeCar : IPrototype<PrototypeCar>
{
    public string Model { get; set; }
    public string Color { get; set; }

    public PrototypeCar Clone()
    {
        // Create a new object with the same property values
        return new PrototypeCar
        {
            Model = this.Model,
            Color = this.Color
        };
    }
}
