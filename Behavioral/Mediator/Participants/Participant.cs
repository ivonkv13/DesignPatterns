// Colleague (Participant)
public abstract class Participant
{
    protected IChatMediator _mediator;

    protected Participant(IChatMediator mediator) => _mediator = mediator;

    public abstract void Send(string message);
    public abstract void Receive(string message);
}
