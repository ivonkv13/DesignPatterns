// Mediator Interface
public interface IChatMediator
{
    void SendMessage(string message, Participant participant);
    void AddParticipant(Participant participant);
}
