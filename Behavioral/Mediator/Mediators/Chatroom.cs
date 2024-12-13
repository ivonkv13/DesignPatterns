
// Concrete Mediator
public class Chatroom : IChatMediator
{
    private List<Participant> _participants = new List<Participant>();

    public void AddParticipant(Participant participant) => _participants.Add(participant);

    public void SendMessage(string message, Participant sender)
    {
        foreach (var participant in _participants)
        {
            if (participant != sender)
            {
                participant.Receive(message);
            }
        }
    }
}
