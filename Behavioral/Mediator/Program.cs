namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Defines an object that encapsulates how a set of objects interact. It promotes loose coupling by preventing direct communication between objects, relying instead on a mediator.

            //Real-life analogy:
            //In a "chatroom", participants don’t talk directly; they communicate through the chatroom (mediator), which handles message delivery.

            IChatMediator chatroom = new Chatroom();

            Participant user1 = new User("Alice", chatroom);
            Participant user2 = new User("Bob", chatroom);
            Participant user3 = new User("Charlie", chatroom);

            chatroom.AddParticipant(user1);
            chatroom.AddParticipant(user2);
            chatroom.AddParticipant(user3);

            user1.Send("Hello, everyone!");
            // Output:
            // Alice sends: Hello, everyone!
            // Bob receives: Hello, everyone!
            // Charlie receives: Hello, everyone!
        }
    }
}
