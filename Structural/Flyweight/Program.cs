namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shares objects to minimize memory usage.

            //Real-life analogy:
            //A "text editor" reuses character fonts to save memory.

            var factory = new CharacterFactory();
            Character a1 = factory.GetCharacter('A', "Arial");
            Character a2 = factory.GetCharacter('A', "Arial");

            Console.WriteLine(ReferenceEquals(a1, a2)); // Verify if the characters are the same.
        }
    }
}
