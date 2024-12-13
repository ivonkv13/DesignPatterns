// Concrete Colleagues
public class User : Participant
{
    public string Name { get; }

    public User(string name, IChatMediator mediator) : base(mediator) => Name = name;

    public override void Send(string message)
    {
        Console.WriteLine($"{Name} sends: {message}");
        _mediator.SendMessage(message, this);
    }

    public override void Receive(string message) => Console.WriteLine($"{Name} receives: {message}");
}