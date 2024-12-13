namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Passes a request along a chain of handlers. Each handler can either process the request or pass it to the next handler.

            //Real-life analogy:
            //In a "call center", customer requests are escalated until they reach someone who can handle them.

            var levelOne = new LevelOneSupport();
            var levelTwo = new LevelTwoSupport();
            var levelThree = new LevelThreeSupport();

            levelOne.SetNextHandler(levelTwo);
            levelTwo.SetNextHandler(levelThree);

            levelOne.HandleRequest("Basic Issue");
            // Output: Level One Support handled the issue.

            levelOne.HandleRequest("Intermediate Issue");
            // Output: Level Two Support handled the issue.

            levelOne.HandleRequest("Complex Issue");
            // Output: Level Three Support handled the issue.
        }
    }
}
